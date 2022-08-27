using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomenMove : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.right * 6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
        /*rb.AddForce(Vector3.right * 0.03f);
        rb.AddForce(Vector3.up * 0.02f);*/
        
        float vel = rb.velocity.magnitude;
        /*if (vel <= 1.0f)
        {
            rb.AddForce(Vector3.right * 0.05f);
            rb.AddForce(Vector3.up * 0.04f);
        }*/
        Debug.Log(vel);
    }
}
