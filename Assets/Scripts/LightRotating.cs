using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotating:MonoBehaviour
{
    public float maxAccelerationTime=5f;
    public float rotationSpeed=0.5f;
    private GuardMovement gm;
    private GameObject player;
    private LightTriggering lt;
    private float targetAngle;
    private float timeLeft;
    public void Start()
    {
        this.gm=GetComponentInParent<GuardMovement>();
        this.player=GameObject.Find("Player");
        this.lt=GetComponentInChildren<LightTriggering>();
    }
    public void Update()
    {
        if(this.gm.isTriggered)
        {
            var dir=this.player.transform.position-transform.position;
            var angle=Mathf.Atan2(dir.y, dir.x)*Mathf.Rad2Deg-this.lt.transform.localRotation.eulerAngles.z+180f;
            transform.rotation=Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else
        {
            this.timeLeft-=Time.deltaTime;
            if(this.timeLeft<=0)
            {
                this.targetAngle=Random.Range(0f, 360f);
                this.timeLeft+=Random.Range(1f, this.maxAccelerationTime);
            }
            transform.rotation=Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, Random.Range(0, 2)>0.5?this.targetAngle++:this.targetAngle--), this.rotationSpeed*Time.deltaTime);
        }
    }
}
