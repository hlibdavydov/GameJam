﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenItemsPlayer : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private Vector3 movement;
    private bool carryingItem;
    private GameObject holding;
    [SerializeField] float timeLeft;
    [SerializeField] int itemsToPlace;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().gravityScale = 0;
        carryingItem = false;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        movement = new Vector2(horizontalMovement, verticalMovement).normalized;
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            //scena lose
            print("lose");
        }
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().MovePosition(transform.position + movement * (speed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!carryingItem)
        {
            carryingItem = true;
            holding = collision.gameObject;
            collision.gameObject.GetComponent<FallenItemsScript>().rb.velocity = new Vector2(0, -1000);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            if (carryingItem)
            {
                if (collision.gameObject.GetComponent<PlatformScript>().color == holding.GetComponent<FallenItemsScript>().color)
                {
                    holding = null;
                    carryingItem = false;
                    itemsToPlace--;
                    if(itemsToPlace == 0)
                    {
                        //scena win
                        print("win");
                    }
                }
                else
                {
                    //scena lose
                    print("lose");
                }
            }
        }
    }
}