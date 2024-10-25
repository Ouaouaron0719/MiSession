using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSpwaner : MonoBehaviour
{
    [SerializeField]public GameObject spikePrefab; 
    public float spawnInterval = 2f; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnSpike", 0f, spawnInterval);
    }

    void SpawnSpike()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, 0);
        Instantiate(spikePrefab, spawnPosition, Quaternion.identity);
        Debug.Log($"spawnPosition: {spawnPosition}");
    }
}
