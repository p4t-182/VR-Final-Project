using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whack : MonoBehaviour
{
    [SerializeField]
    private GameObject Whammer; 
    // Start is called before the first frame update


    

    void OnCollisionEnter(Collision __){
        
        Score.AddScore(2);
    }

   
}
