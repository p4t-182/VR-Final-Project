using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whack : MonoBehaviour
{
    [SerializeField]
    private GameObject Whammer; 
    // Start is called before the first frame update


    // so for this when the mallet successfully hits the gopher, the player score goes up
    // where is score being stored??

    void OnCollisionEnter(Collision __){
        
        Score.AddScore(2);
    }

   
}
