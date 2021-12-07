using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject floor, player;
    public float cooldownTime;
    private float nextSpawnTime;


    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > nextSpawnTime)
        {
            obstacleSpawn_R();
            nextSpawnTime = Time.time + cooldownTime;
        }
    }

    //Leave this for now
    private void obstacleSpawn_R()
    {
        float minimum = floor.transform.position.x - floor.GetComponent<BoxCollider>().bounds.size.x / 2 + obstaclePrefab.GetComponent<BoxCollider>().bounds.size.x/2;
        float max = floor.transform.position.x + floor.GetComponent<BoxCollider>().bounds.size.x / 2 - obstaclePrefab.GetComponent<BoxCollider>().bounds.size.x / 2;
        Instantiate(obstaclePrefab, new Vector3(Random.Range(minimum, max), 0, player.transform.position.z + 20), Quaternion.identity);
    }
}
