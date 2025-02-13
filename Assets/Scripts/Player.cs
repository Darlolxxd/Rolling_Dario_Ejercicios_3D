using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    int vidas;
     
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
       
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Saltar();
        }
       
        if (CheckGameOverCondition()) {
            Time.timeScale = 0f;  // pause play
            SceneManager.LoadScene("RollBallGameOver");
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
        rb.AddForce(0, 4, 0, ForceMode.Impulse);

    }

    bool CheckGameOverCondition()
    {
        // If the ball falls, the game is over
        if (transform.position.y <= -50)
        {
            return true;
        }
        else
        {
             return false;  // Replace with actual condition
        }
      
    }





}




