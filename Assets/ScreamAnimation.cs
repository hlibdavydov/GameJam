using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ScreamAnimation : MonoBehaviour
{

    [SerializeField] bool startAnimation;
    [SerializeField] float distanceToTravel = 0.5f;
    [SerializeField] float timeToTravel = 2f;
    float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        startAnimation = false;
        speed = distanceToTravel / timeToTravel;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
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
