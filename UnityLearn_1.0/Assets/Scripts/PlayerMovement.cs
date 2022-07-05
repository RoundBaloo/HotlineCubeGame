using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    private float forwardForce = 70.0f;
    private float sidewaysForce = 40.0f;

    // FixedUpdate - предпочтительно использовать для физики
    public void FixedUpdate() 
    {
        rb.AddForce(0, 0, forwardForce);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1.0f) 
        {
            FindObjectOfType<Manager>().GameOver();
        }

        if (rb.position.y >= 950.0f) 
        {
            GetComponent<PlayerMovement>().enabled = false;
        }

    }
}
