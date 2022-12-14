using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10;
    private float deadZone = 0;
    [SerializeField] LogicManager logic;

    void Start()
    {
        deadZone = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 5;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Update()
    {
        moveSpeed = 10 + (logic.getScore() / 3);
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if(transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }
}
