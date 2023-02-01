using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlONE : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed=10f;
    

    public float horizontalInput;
    public float forwardInput;

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
