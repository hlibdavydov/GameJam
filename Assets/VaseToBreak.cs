using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseToBreak : MonoBehaviour
{
    private void Awake()
    {
        if (Player._playerProgress.vaseGameFinished)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
