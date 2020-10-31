using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingStars : MonoBehaviour
{
    [SerializeField] private GameObject flashingStars;

    [SerializeField] [Tooltip("In soconds")]
    private float timeGap;
    private bool isFlashing;
    
    private void Update()
    {
        if (!isFlashing)
        {
            StartCoroutine(Flash());
            
        }
    }

    private IEnumerator Flash()
    {
        flashingStars.SetActive(true);
        isFlashing = true;
        yield return new WaitForSeconds(timeGap);
        flashingStars.SetActive(false);
        yield return new WaitForSeconds(timeGap);
        isFlashing = false;
    }
}
