using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ScreamAnimation : MonoBehaviour
{
    [SerializeField] private GameObject fuseBoxToActivate;
    [SerializeField] float distanceToTravel = 0.5f;
    [SerializeField] float timeToTravel = 2f;
    float speed;
    bool startAnimation;
    private Rigidbody2D rb;

    void Start()
    {
        startAnimation = false;
        speed = distanceToTravel / timeToTravel;
        rb = GetComponent<Rigidbody2D>();
        fuseBoxToActivate.SetActive(false);
    }

    private void OnMouseUpAsButton()
    {
        startAnimation = true;

        fuseBoxToActivate.SetActive(true);
        Destroy(GetComponent<InteractableObject>().tooltip);
        Destroy(GetComponent<InteractableObject>());
    }

    void Update()
    {
        if (startAnimation)
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0);
            distanceToTravel -= speed * Time.deltaTime;

            if (distanceToTravel <= 0)
            {
                startAnimation = false;
            }
        }
    }
}