using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Hola desde awake");
    }

    int x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("Hola Mundo desde Start");
        //Debug.LogWarning("Algo salio medianamente mal");
        //Debug.LogError("Algo salio muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);
        Debug.Log("Hola desde Update");
    }

    private void FixedUpdate()
    {
        Debug.LogError("Hola desde FixedUpdate cada 50 frames");

    }

    private void LateUpdate()
    {
        Debug.LogWarning("Hola desde LateUpdate");
    }

    private void OnEnable()
    {
        Debug.Log("El objeto a sido habilitado");

    }

    private void OnDisable()
    {
        Debug.Log("El objeto a sido inabilitado");

    }
}
