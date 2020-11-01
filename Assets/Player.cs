using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static PlayerPosition playerPosition;

    private void Start()
    {
        if (playerPosition == null)
        {
            playerPosition = new PlayerPosition();
        }
    }

    private void Update()
    {
        playerPosition.position = transform.position;
    }

    private void OnEnable()
    {
        if (playerPosition != null)
        {
            transform.position = playerPosition.position;
        }
    }
}