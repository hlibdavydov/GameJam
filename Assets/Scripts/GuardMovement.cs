using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardMovement:MonoBehaviour
{
    public float pause=1f;
    public float speed=3f;
    public float triggeredSpeed=2f;
    [HideInInspector]
    public bool isTriggered=false;
    private Rigidbody2D guardBody;
    private Vector3 movement;
    private float timeLeft;
    public void SetTriggerValue(bool value)
    {
        this.isTriggered=value;
    }
    public void Start()
    {
        this.guardBody=GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        this.timeLeft-=Time.deltaTime;
        if(this.timeLeft<=0)
        {
            this.movement=new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
            this.timeLeft+=this.pause;
        }
        if(this.isTriggered)
        {
            this.movement=GameObject.Find("Player").transform.position-transform.position;
            transform.Translate(this.movement*this.triggeredSpeed*Time.deltaTime);
        }
        else this.guardBody.MovePosition(transform.position+this.movement*this.speed*Time.deltaTime);
    }
}
