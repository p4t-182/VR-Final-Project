using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{
    public static int score  = 0;

    public static int totalscore = 0;

   

    public static void AddScore(int v){
        Score.score += v;
    }


   
}
