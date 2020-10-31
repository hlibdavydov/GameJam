using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenItemsScript : MonoBehaviour
{
    public string color;

    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
