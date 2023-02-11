using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class Spawner : MonoBehaviour
{
    public GameObject enemyCircle;
    public Transform[] spawnPoints;
    private float timer;
    public float spawnDelay;
    
    void Start()
    {
        timer = Time.time + spawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Time.time)
        {
            int chosenSpawnPointIndex = Random.Range(0, spawnPoints.Length);
            Transform chosenSpawnPoint = spawnPoints[chosenSpawnPointIndex];
            Instantiate(enemyCircle, chosenSpawnPoint.position, chosenSpawnPoint.rotation);
            timer = Time.time + spawnDelay;
        }
        
    }
}
