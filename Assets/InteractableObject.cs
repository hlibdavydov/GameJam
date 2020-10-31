using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private GameObject tooltip;
    private bool isActive;

    private void Update()
    {
        if()
    }

    private void Start()
    {
        tooltip.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ShowTooltip();
        isActive = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        tooltip.SetActive(false);
        isActive = false;
    }

    private void ShowTooltip()
    {
        tooltip.SetActive(true);
    }
}
