using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente3 : MonoBehaviour
{
    private void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        Componente1.miObjecto.name = "nuevoNombreDeMiObjecto";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
