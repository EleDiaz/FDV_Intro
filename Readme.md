# Fundamentos de Desarrollo de Videojuegos

En la siguiente práctica se ha inicializado una escena básica en la cual se han añadido los assets standard de unity de tercera persona. A su vez se modificado la escena con el fin de simplificarla.

- Se han desactivado la geometría del personaje principal y se ha reemplazado por un cubo y una esfera. Estos nuevos se les ha eliminado las colisiones para evitar bugs con la colisión por defecto del personaje inicial.
- Se han añadido varias luces de colores.
- Y la incorporación de un pequeño script (un hello world).

Todo la práctica esta bajo un control de versiones git+lfs en el siguiente repositorio.

[Repo: https://github.com/EleDiaz/FDV_Intro](https://github.com/EleDiaz/FDV_Intro)

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelloWorld : MonoBehaviour
{
    int simpleInt = 0;

    // Start is called before the first frame update
    void Start()
    {
      Debug.Log("Introducción a Fundamentos de Desarrollo de Videojuegos");
    }

    // Update is called once per frame
    void Update()
    {
      simpleInt++;
      Debug.Log("Introducción a Fundamentos de Desarrollo de Videojuegos" + simpleInt);
    }
}
```

![](./video.gif)