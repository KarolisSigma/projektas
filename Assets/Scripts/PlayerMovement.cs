using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float X;
    private float Z;
    private float Y;
    private Transform tr;
    private Rigidbody rb;
    private int speed=10;
    private int jumpforce=3;
    private CharacterController ch;
    private Vector3 velocity;
    private bool grounded=true;

    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        ch = GetComponent<CharacterController>();
    }

    void Update()
    {

        X = Input.GetAxis("Horizontal");
        Z = Input.GetAxis("Vertical");
        //Y = Input.GetAxis("Jump");

        //tr.position += (new Vector3(X, 0, Z) * Time.deltaTime * speed);

        if (!ch.isGrounded)
        {
            velocity += Vector3.down * 9.81f * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space)&&grounded)
        {
            //rb.AddForce(Vector3.up * jumpforce * Y, ForceMode.VelocityChange);
            velocity += Vector3.up * jumpforce;
        }


        //tr.Translate(velocity);
        
        ch.Move(new Vector3(X, velocity.y, Z) * Time.deltaTime * speed);

    }
}
