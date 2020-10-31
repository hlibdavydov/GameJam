using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float speed = 5;
    
    private Vector3 movement;
    void Start()
    {
        rigidbody2D = gameObject.AddComponent<Rigidbody2D>();
        rigidbody2D.gravityScale = 0;

    }

    void Update()
    {
        HandleInput();
    }

    private void FixedUpdate()
    {
        rigidbody2D.MovePosition(transform.position + movement * (speed * Time.deltaTime));
    }

    private void HandleInput()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        movement = new Vector2(horizontalMovement, verticalMovement).normalized;
    }
}
