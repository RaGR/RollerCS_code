using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn_Test : MonoBehaviour
{
    public GameObject Player;
    public GameObject[] obstaclePrefabs;

    public float spawnHeight;
    public float spawnDelay;
    private int rand_int, last_rand = -1;
    private float lastSpawnTime;
    private Rigidbody rb;
    void Start()
    {
        rb = Player.GetComponent<Rigidbody>();
    }
    void Update()
    {   
        Debug.Log(Time.time);
        // Check if it's time to spawn a new obstacle
        if (Time.time > lastSpawnTime + spawnDelay/rb.velocity.z)
        {
            lastSpawnTime = Time.time;

            // Calculate a random x position for the obstacle

            // Instantiate the obstacle at the specified height and position
            rand_int = (int)Random.Range(0f,(float)obstaclePrefabs.Length - 0.1f);
            while(last_rand == rand_int){
                rand_int = (int)Random.Range(0f,(float)obstaclePrefabs.Length - 0.1f);
            }
            Vector3 spawnPos = new Vector3(obstaclePrefabs[rand_int].transform.position.x, spawnHeight, Player.transform.position.z + 20);
            Instantiate(obstaclePrefabs[rand_int], spawnPos, obstaclePrefabs[rand_int].transform.rotation);
            last_rand = rand_int;
        }
    }
}
