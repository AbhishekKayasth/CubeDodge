using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlocks : MonoBehaviour {

    public Transform[] SpawnPoints;
    public GameObject BlockPrefab;
    private float timeToSpawn = 2f;
    public float timeBetweenWaves = 1f;
    

	void Update () 
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlock();
            timeToSpawn = Time.time + timeBetweenWaves;
        }        
        
        
	}

    void SpawnBlock()
    {
        int randomIndex = Random.Range(0, SpawnPoints.Length);

        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(BlockPrefab, SpawnPoints[i].position, Quaternion.identity);
            }

        }
    }

}
