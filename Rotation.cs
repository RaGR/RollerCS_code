using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private Vector3 rotation_Speed;
    void Start()
    {
        rotation_Speed.Set(0f, 20f, 0f);
    }
    void Update()
    {
        transform.Rotate(rotation_Speed * Time.deltaTime);
    }
}
