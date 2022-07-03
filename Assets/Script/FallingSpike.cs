using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    public GameObject spikePrefab;
    public GameObject spikeSpawn;
    public float spawnTime = 1f;
    void Start()
    {
        StartCoroutine(spawnSpikeCountdown());
    }

    void Update()
    {
        
    }
    IEnumerator spawnSpikeCountdown()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnSpike();
        }
    }
    private void spawnSpike()
    {
        GameObject spike = Instantiate(spikePrefab,spikeSpawn.transform.position,spikePrefab.transform.rotation) ;
        

    }
}
