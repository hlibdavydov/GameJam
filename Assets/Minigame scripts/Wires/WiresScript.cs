using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WiresScript : MonoBehaviour
{

    float speed = 200;
    private Rigidbody2D rb;
    // Public do testowania, po stworzeniu odpowiednich grafik można usunąć
    public bool lit;
    public bool cutToLose;
    public bool cutToWin;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lit = false;
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
                    // SceneManager.LoadScene("Win");
                    print("win");
                }
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        lit = true;
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
        lit = false;
        cutToLose = false;
        cutToWin = false;
    }
}
