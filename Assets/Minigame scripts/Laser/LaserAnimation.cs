using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class LaserAnimation : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite sprite0, sprite1, sprite2;
    public float change;
    private float currentChange;
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        currentChange = change;
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentChange -= Time.deltaTime;
        if (currentChange <= 0)
        {
            currentChange = change;
            counter++;
            if(counter%3 == 0)
            {
                sr.sprite = sprite0;
            }else if(counter%3 == 1)
            {
                sr.sprite = sprite1;
            }
            else
            {
                sr.sprite = sprite2;
            }
        }
    }
}
