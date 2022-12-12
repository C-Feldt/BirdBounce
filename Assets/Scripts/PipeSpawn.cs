using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] GameObject pipe;
    [SerializeField] float spawnRate = 2;
    [SerializeField] float heightOffset = 10; 
    private float timer = 0;

    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        if(timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
