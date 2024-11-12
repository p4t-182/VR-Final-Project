using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SomeData
{
    public static int score  = 0;

    public static int playerLevel = 0; // static datastore that does not get reset unless the application is restarted

    public static void AddScore(int v){
        SomeData.score += v;
    }
}
