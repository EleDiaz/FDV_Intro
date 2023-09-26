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
