using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    [Header("Player RigidBody")]
    public Rigidbody playerRB; //Rigidbody del jugador


    [Header("Movement variables")]
    public float speed; //Velocidad de la bola
    float horInput; //Almacén del Vector X del input (teclado)

    [Header("Jump Variables")]
    public float jumpForce;
    bool isGrounded = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horInput = Input.GetAxis("Horizontal");
        Jump();
    }


    private void FixedUpdate()
    {
        Movement();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }



    void Movement()
    {
        playerRB.velocity = new Vector3(horInput * speed, playerRB.velocity.y);
    }


    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                isGrounded = false;
                playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }



}
