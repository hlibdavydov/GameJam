using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class KeyDropzone : MonoBehaviour, IDropHandler, IPointerClickHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        print("Dropped");
        if (eventData.pointerDrag.TryGetComponent(out ScreenKey key))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        print("pointer enter");
    }
}
