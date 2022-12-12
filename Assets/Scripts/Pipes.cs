using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5;
    private float deadZone = 0;

    void Start()
    {
        deadZone = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 5;
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }
}
