using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        movement = new Vector2(horizontalMovement, verticalMovement).normalized;
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().MovePosition(transform.position + movement * (speed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Laser"))
        {
            print("lose");
        }
        else if (collision.gameObject.CompareTag("Goal"))
        {
            print("win");
        }
    }
}
