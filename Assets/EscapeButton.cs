﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EscapeButton : MonoBehaviour
{
    public void LoadMainScreen()
    {
        SceneManager.LoadScene("MainScene");
        print("Clicked");
    }
}
