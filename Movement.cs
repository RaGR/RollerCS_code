// 14.05.23 Left and right limits has to be fixed!!!
// **************************
// **************************
//      Рудолф & Ragr
// **************************
// **************************
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    public float forward_speed = 1.5f; // Player movement speed
    public float control_speed = 200f;
    public float back_speed, x_initial, limit = 2;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("Player collided with obstacle");
            transform.position = Vector3.zero;
            transform.rotation.Set(0f,0f,0f,1);
        }
    }

    void Start()
    {   
        back_speed = forward_speed / 2f;
        x_initial = transform.position.x;
    }

    void Update()
    {   

        // Move player forward
        transform.Translate(Vector3.forward * forward_speed * Time.deltaTime);

        // WASD controls
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * forward_speed * Time.deltaTime); // Move forward
        }

        if (Input.GetKeyDown(KeyCode.A) && x_initial - (transform.position.x + control_speed * 0.005) <= limit)
        {
            transform.Translate(Vector3.left * control_speed * Time.deltaTime); // Move left
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * back_speed * Time.deltaTime); // Move back
        }

        if (Input.GetKeyDown(KeyCode.D) && (transform.position.x + control_speed * 0.005) - x_initial <= limit)
        {
            transform.Translate(Vector3.right * control_speed * Time.deltaTime); // Move right
        }
    }
}
