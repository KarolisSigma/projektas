using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float X;
    private float Z;
    private Transform tr;
    private Transform cam;
    private int speed=10;
    private Vector3 offset;


    void Start()
    {
        tr = GetComponent<Transform>();
        cam = GameObject.Find("Camera").GetComponent<Transform>();
        offset = new Vector3(0,1,-2);
    }

    void Update()
    {

        X = Input.GetAxisRaw("Horizontal");
        Z = Input.GetAxisRaw("Vertical");
        //Y = Input.GetAxis("Jump");
        
        tr.position += new Vector3(X, 0, Z).normalized * Time.deltaTime * speed;
        cam.position = tr.position + offset;


    }
}
