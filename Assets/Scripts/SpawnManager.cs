using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20; 
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public Transform[] spawnPoints; 
    public float spawnRate = 2f; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpanwRandomAnimal", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void SpanwRandomAnimal()
    {
        //Randomly generate animal index and spawn position 
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int spawnIndex = Random.Range(0,spawnPoints.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX ), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPoints[spawnIndex].position , animalPrefabs[animalIndex].transform.rotation);
    }
}

