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
    float verInput; //Almacén del Vector Y del input (teclado), (se pasará al Z de la bola, porque el Y de la bola es hacia arriba no hacia delante)


    [Header("Jump Variables")]
    public float jumpForce;
    bool isGrounded = true;


    private Vector3 movePlayer;


    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horInput = Input.GetAxis("Horizontal");
        verInput = Input.GetAxis("Vertical");
        Jump();
        
        CamDirection();

        movePlayer = playerInput.x * camRight + playrInput.z * camForward;
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
        playerRB.velocity = new Vector3(horInput * speed, playerRB.velocity.y, verInput * speed);
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
    
    void CamDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;

    }




}
