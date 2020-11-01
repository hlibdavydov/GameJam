using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static PlayerProgress _playerProgress;
    [SerializeField] private GameObject doorToNextLevel;

    private void Awake()
    {
    }

    private void Start()
    {
        if (_playerProgress == null)
        {
            _playerProgress = new PlayerProgress();
        }
    }

    private void Update()
    {
        _playerProgress.position = transform.position;
    }

    private void OnEnable()
    {
        if (SceneManager.GetActiveScene().name == "MainScene")
        {
            if (_playerProgress == null) return;
            transform.position = _playerProgress.position;

            if (_playerProgress.pinCodeGameFinished)
            {
                doorToNextLevel.GetComponent<InteractableObject>().isOpen = true;
            }
        }else if(SceneManager.GetActiveScene().name == "Level2")
        {
        }
    }
}