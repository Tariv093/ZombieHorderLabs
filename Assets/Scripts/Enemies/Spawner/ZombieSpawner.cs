using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{

    [SerializeField] private int numZombiesSpawn;

    [SerializeField] private GameObject[] zombiePrefabs;
    [SerializeField] private SpawnerVolume[] spawnVols;

    private GameObject followobject;
    // Start is called before the first frame update
    void Start()
    {
        followobject = GameObject.FindGameObjectWithTag("Player");

        for (int zombieCount = 0; zombieCount < numZombiesSpawn; zombieCount++)
        {
            SpawnZombie();
        }
    }

    private void SpawnZombie()
    {
        GameObject zombieSpawned = zombiePrefabs[UnityEngine.Random.Range(0, zombiePrefabs.Length)];
        SpawnerVolume spVols = spawnVols[UnityEngine.Random.Range(0, spawnVols.Length)];

        GameObject zombie = Instantiate(original: zombieSpawned, spVols.GetPositionInBounds(), spVols.transform.rotation);

        zombie.GetComponent<ZombieComponent>().Initialize(followobject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
