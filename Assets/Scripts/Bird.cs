using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] Rigidbody2D myRigidbody;
    [SerializeField] float jumpVelocity = 10;
    [SerializeField] LogicManager logic;
    [SerializeField] bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive) {
            myRigidbody.velocity = Vector2.up * jumpVelocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }

}
