using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlONE : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed=10f;
    
    // public float increment;
    //public GameObject rb;
    //rigidbody rb;
    // rb = getcomponent<rigidbody>();
    // private Vector3 targetPos;

    public float horizontalInput;
    public float forwardInput;


    // Vector3 rotationRight = new Vector3(0, 30, 0);
    // Vector3 rotationLeft = new Vector3(0, -30, 0);

    void Update()
    {
        // horizontalInput = Input.GetAxis("Mouse X");
        // forwardInput = Input.GetAxis("Mouse Y");

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
        
    }
   
}
