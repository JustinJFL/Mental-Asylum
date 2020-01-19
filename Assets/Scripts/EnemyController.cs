using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float moveSpeed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //makes enemy walk directly towards player current position
        transform.LookAt(GameObject.FindGameObjectWithTag("Player").transform);
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        Destroy(gameObject,Random.Range(7.0f,12.0f));
    }
}