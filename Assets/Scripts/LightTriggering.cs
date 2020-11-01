using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTriggering:MonoBehaviour
{
    private GuardMovement gm;
    public void Start()
    {
        this.gm=GetComponentInParent<GuardMovement>();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="Player") gm.SetTriggerValue(true);
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name=="Guard") gm.SetTriggerValue(false);
    }
}
