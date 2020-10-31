using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZmianaDlugosci : MonoBehaviour
{

    float changeSpeed = 0.005f;
    float timeToChange = 3f;
    bool shorten;
    // Start is called before the first frame update
    void Start()
    {
        shorten = true;
    }

    // Update is called once per frame
    void Update()
    {
        timeToChange -= Time.deltaTime;
        if (timeToChange <= 0)
        {
            timeToChange = 1.8f;
            if (shorten)
            {
                shorten = false;
            }
            else
            {
                shorten = true;
            }
        }
        if (shorten)
        {
            transform.localScale -= new Vector3(0, changeSpeed, 0);
        }
        else
        {
            transform.localScale += new Vector3(0, changeSpeed, 0);
        }
    }
}
