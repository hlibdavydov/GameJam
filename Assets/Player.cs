using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static Player player;

    private void Start()
    {
        if (player != null)
        {
            Destroy(gameObject);
        }
        else
        {
            player = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}