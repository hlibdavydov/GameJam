using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] public GameObject tooltip;
    [SerializeField] private string scene;
    public Action OnInteraction;
    private bool isActive;

    
    private void Start()
    {
        OnInteraction = () =>
        {
            if (scene == null) return;
            SceneManager.LoadScene(scene);
        };
        tooltip.SetActive(false);
    }
    private void Update()
    {
        if (!isActive) return;
        if (Input.GetKeyDown(KeyCode.E))
        {
            OnInteraction();
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (tooltip == null) return;
        if (other.GetComponent<Player>() == null) return;
        ShowTooltip();
        isActive = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (tooltip == null) return;
        if (other.GetComponent<Player>() == null) return;
        tooltip.SetActive(false);
        isActive = false;
    }

    private void ShowTooltip()
    {
        tooltip.SetActive(true);
    }
}
