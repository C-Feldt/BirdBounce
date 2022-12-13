using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] Rigidbody2D myRigidbody;
    [SerializeField] float jumpVelocity = 10;
    [SerializeField] LogicManager logic;
    public bool birdIsAlive = true;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6) {
            logic.gameOver();
            birdIsAlive = false;
        }
    }
}
