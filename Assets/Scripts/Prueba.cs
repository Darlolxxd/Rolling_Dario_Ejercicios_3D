using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    public float velocidad = 5f;
    public float tiempoCambioDireccion = 2f;
    private Vector3 direccion;
    private float temporizador;



    // Start is called before the first frame update
    void Start()
    {
        direccion = Vector3.up;
        temporizador = tiempoCambioDireccion;
    }
   

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccion* velocidad * Time.deltaTime);
        temporizador -= Time.deltaTime;
        if (temporizador < 0)
        {
            direccion = -direccion;
            temporizador = tiempoCambioDireccion;
        }
        
    }
}
