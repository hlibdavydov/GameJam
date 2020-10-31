using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obracanie : MonoBehaviour
{

    public float rotationSpeed = 45;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += Vector3.forward * rotationSpeed * Time.deltaTime;
    }
}
