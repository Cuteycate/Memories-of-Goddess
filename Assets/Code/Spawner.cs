using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Update is called once per frame
    public Transform[] spawnPoint;

    float timer;

    void Awake()
    {
        spawnPoint = GetComponentsInChildren<Transform>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            GameObject enemy = GameManager.instance.pool.Get(Random.Range(0, 2));
            enemy.transform.position = spawnPoint[Random.Range(1,spawnPoint.Length)].position;
            
        }
    }
}
