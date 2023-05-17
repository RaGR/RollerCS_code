using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_Physics : MonoBehaviour
{   
    Rigidbody rb;
    public float force = 10;
    public GameObject soul;
    public float limit_forward = 4f;
    public float limit_sides = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(rb.velocity.z) <= limit_forward)
        {
            rb.AddForce(soul.transform.forward * force);
        }
        if (Input.GetKey(KeyCode.S) && Mathf.Abs(rb.velocity.z) <= limit_forward)
        {
            rb.AddForce(Vector3.back * (force / 2));
        }
        if (Input.GetKey(KeyCode.D) && Mathf.Abs(rb.velocity.x) <= limit_sides)
        {
            rb.AddForce(Vector3.right * force * 2);
        }
        if (Input.GetKey(KeyCode.A) && Mathf.Abs(rb.velocity.x) <= limit_sides)
        {
            rb.AddForce(Vector3.left * force * 2);
        }
    }
}
