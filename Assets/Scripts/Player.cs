using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
       
        if (Input.GetKey(KeyCode.Space))
        {

            Saltar();


        }
    }
    void Movimiento()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * 3 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right *3 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * 3 * Time.deltaTime;
        }
    }
    void Saltar()
    {
        rb.AddForce(0,3, 0, ForceMode.Impulse);
    }



}




