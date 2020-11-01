using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    [SerializeField] private Transform objectToFollow;
    private Vector3 offset;
    
    void Start()
    {
        objectToFollow = FindObjectOfType<Player>().gameObject.transform;
        offset = transform.position - objectToFollow.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = objectToFollow.position + offset;
    }
}
