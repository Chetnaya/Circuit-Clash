using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraCarsControl : MonoBehaviour
{
    public float speed = 20f;
    public float horizontalInput;

    // Update is called once per frame
    void Update()
    {
        // horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);
    }
}
