using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GopherTest : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> pucks;
    private int listLen, randIdx, prevIdx;
    private float prevTime, currTime;

    // Update is called once per frame
    void Start()
    {
        prevTime = Time.time;
        if(pucks != null)
        {
            listLen = pucks.Count;
            for (int i = 0; i < listLen; i++)
            {
                pucks[i].GetComponent<SpringJoint>().spring = 0;
            }
            randIdx = Random.Range(0, listLen);
        }
        
    }

    void Update()
    {
        currTime = Time.time;
        prevIdx = randIdx;
        pucks[randIdx].GetComponent<SpringJoint>().spring = 100;
        if((currTime - prevTime) > 2.0f)
        {
            prevTime = currTime;
            randIdx = Random.Range(0, listLen);
            pucks[prevIdx].GetComponent<SpringJoint>().spring = 0;
        }
    
    }
}
