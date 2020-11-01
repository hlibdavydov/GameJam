using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] public GameObject tooltip;
    [SerializeField] private string scene;
    [SerializeField] string nextLevel;

    public Action OnInteraction;
    private bool isActive;
    public bool isOpen;

    private void Start()
    {
        OnInteraction = () =>
        {
            if (scene == null) return;
            if (isOpen)
            {
                
                Destroy(gameObject);
                SceneManager.LoadScene(nextLevel, LoadSceneMode.Additive);
            }
            else
            {
                SceneManager.LoadScene(scene);
            }
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