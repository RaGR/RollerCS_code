using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed_Camera : MonoBehaviour
{
    private Vector3 initial_pos, move;
    public GameObject Player;
    private float z_diff;
    // Start is called before the first frame update
    void Start()
    {
        z_diff = Player.transform.position.z - transform.position.z;
        initial_pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move.Set(initial_pos.x, initial_pos.y, Player.transform.position.z - z_diff);
        transform.position = Vector3.MoveTowards(transform.position, move, 0.1f);
    }
}
