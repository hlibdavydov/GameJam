using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseBox : MonoBehaviour
{
    [SerializeField] private GameObject fuseBoxToActivate;
    
    void Start()
    {
        fuseBoxToActivate.SetActive(false);
        var interactableObject = GetComponent<InteractableObject>();
        interactableObject.OnInteraction = () =>
        {
            fuseBoxToActivate.SetActive(true);
        };
    }
    
}
