using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GopherTest : MonoBehaviour
{
    private SpringJoint puck;
    // Update is called once per frame
    void Start()
    {
        puck = GetComponent<SpringJoint>();
        puck.spring = 500;
    }
}
