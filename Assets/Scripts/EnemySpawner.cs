using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform Spawner;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    
    //void Start()
    //{
        //InvokeRepeating("Spawnenemy", spawnTime, spawnDelay);
    //}


    public void Spawnenemy()
    {
        Instantiate(enemy, Spawner.position, transform.rotation);
        //if (stopSpawning)
        //{
            //CancelInvoke("Spawnenemy");
        //}
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            InvokeRepeating("Spawnenemy", spawnTime, spawnDelay);
        }
        else
        {
            CancelInvoke("Spawnenemy");
        }
            
    }
    
}
