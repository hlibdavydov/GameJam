using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement:MonoBehaviour
{
    public float speed=30f;
    private Rigidbody2D playerBody;
    private Vector3 movement;
    public void Start()
    {
        this.playerBody=GetComponent<Rigidbody2D>();
        this.playerBody.gravityScale=0;
    }
    public void Update()
    {
        this.movement=new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")).normalized;
    }
    public void FixedUpdate()
    {
        this.playerBody.MovePosition(transform.position+this.movement*this.speed*Time.deltaTime);
    }
}
