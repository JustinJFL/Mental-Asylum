using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject enemySpawn;
    public GameObject enemy;
    public Transform enemySpawnPos;

    public float repeatRate;

    private bool spawnStatus;

    // Start is called before the first frame update
    void Start()
    {
        spawnStatus = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered the spawn area");
        //uses invokerepeating to repeadedly spawn enemy at every "repeatRate" seconds
        if(other.gameObject.tag =="Player" && spawnStatus == true)
        {
        InvokeRepeating("SpawnEnemy",.5f, repeatRate);
        //gameObject.GetComponent<BoxCollider>().enabled = false;

        }
    }

    void OnTriggerExit(Collider other)
    {
        spawnStatus = false;
        Debug.Log("left the spawn area");
    }
    void SpawnEnemy()
    {
        Instantiate(enemy,enemySpawnPos.position, enemySpawnPos.rotation);
    }
}

