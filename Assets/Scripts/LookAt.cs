using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{

    public GameObject player;
    
   

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transform.position - (player.transform.position - transform.position));
    }
}
