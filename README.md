# Simple Colour Animation

Example of colour interpolation from C# code.  This example change the `Emission Color` for a simple Cube. 
For more information you can check my [blog](http://blog.jappsku.co/como-crear-una-animacion-de-color-desde-c-en-unity)

## What is inside

### __PlayerCube__
a simple `gameObject`(cube) that has an rotation in axis y and change the emission colour.

### __Player__
a `c# scrtip` that contains the animation to change the emission colour.

### __Start__
Contains two important lines. You can comment and uncomment each one of them and test the game to see the animation changes.

```c#
StartCoroutine(ColorChange(Color.yellow));
//StartCoroutine(Blink());
```

## Author

Jose Aponte, joseapontec@gmail.com

## Licencse

Available under the MIT license. See the LICENSE file for more info.

