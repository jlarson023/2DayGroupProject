using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    public GameObject molePrefab;
    private float spawnRangeY = 4.5f;
    private float spawnRangeX = 9.5f;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMole", delay, delay);
    }

    private Vector2 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        float spawnPosY = Random.Range(-spawnRangeY, spawnRangeY);
        Vector2 randomPos = new Vector2(spawnPosX, spawnPosY);
        return randomPos;
    }

    public void SpawnMole()
    {
        Instantiate(molePrefab, GenerateSpawnPosition(), molePrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
