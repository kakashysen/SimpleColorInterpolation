

using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 DefaultSpeed = new Vector3(0f, 1f, 0f);
    float delayTime = 1.0f;

    Renderer rend;
    void Start()
    {
        rend = GetComponent<Renderer>();
        StartCoroutine(ColorChange(Color.yellow));
        //StartCoroutine(Blink());
    }

    void Update()
    {
        var rotation = DefaultSpeed;
        transform.Rotate(rotation);
    }

    IEnumerator Blink()
    {
        while (true)
        {
            StartCoroutine(ColorChange(Color.red));
            yield return new WaitForSeconds(delayTime);
            StartCoroutine(ColorChange(Color.green));
            yield return new WaitForSeconds(delayTime);
        }
    }

    IEnumerator ColorChange(Color newColor)
    {
        float transitionRate = 0f; 
        while (transitionRate < delayTime)
        {
            rend.material.SetColor("_EmissionColor", Color.Lerp(rend.material.GetColor("_EmissionColor"), newColor, transitionRate));
            transitionRate += Time.deltaTime * (delayTime + 1f);
            yield return null; 
        }
        yield return null; 
    }
}
