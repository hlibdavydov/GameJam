using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class WiresScript : MonoBehaviour
{

    float speed = 200;
    private Rigidbody2D rb;
    private bool cutToLose;
    private bool cutToWin;
    private SpriteRenderer sr;
    public Sprite on, off;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            float xDisplacement = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            float yDisplacement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            rb.velocity = new Vector2(xDisplacement, yDisplacement);
            if (Input.GetKey(KeyCode.Return))
            {
                if (cutToLose)
                {
                    //SceneManager.LoadScene("Lose");
                    print("lose");
                }
                else if (cutToWin)
                {
                    Win();
                }
            }
            if (Input.GetKey(KeyCode.K))
            {
                Win();
            }
        }
    }

    private void Win()
    {
        Player._playerProgress.wiresGameFinished = true;
        SceneManager.LoadScene("MainScene");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sr.sprite = on;
        if (collision.gameObject.CompareTag("Cuttable"))
        {
            cutToLose = true;
        }else if(collision.gameObject.CompareTag("WireToCut"))
        {
            cutToWin = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        sr.sprite = off;
        cutToLose = false;
        cutToWin = false;
    }
}
