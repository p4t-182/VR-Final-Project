using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whack : MonoBehaviour
{
    //private XRGrabInteractable grabInteractable;

    //void Start()
    //{
    //    grabInteractable = GetComponent<XR Grab Interactable>();
    //}
    //void Update()
    //{
    //    if (grabInteractable.isSelected)
    //    {

    //    }
    //}

    void OnCollisionEnter(Collision collider){
        
        if (collider.gameObject.tag == "Gopher")
        {
            Score.AddScore(2);
        }
        
    }

   
}
