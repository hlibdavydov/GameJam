using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private GameObject tooltip;
    [SerializeField] private string scene;
    
    private bool isActive;

    private void Update()
    {
        if (!isActive) return;
        if (Input.GetKeyDown(KeyCode.E))
        {
            LoadMinigame();
        }
    }

    private void LoadMinigame()
    {
        SceneManager.LoadScene(scene);
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
