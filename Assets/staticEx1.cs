using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticEx1 : MonoBehaviour
{
    public static int countMe = 0;
    //static points to the same reference on every instance of the class.
    // Start is called before the first frame update
    void Start()
    {
        countMe++;
    }
     void Update()
    {
        Debug.Log(countMe);
    }
    void OnDestroy() {
        countMe--;
    }

 
   
}
