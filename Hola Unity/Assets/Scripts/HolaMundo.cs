using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hola Mundo");
        Debug.Log("Algo paso");
        Debug.LogWarning("Algo salio medianamente mal");
        Debug.LogError("Algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
