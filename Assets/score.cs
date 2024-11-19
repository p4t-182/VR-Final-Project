using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{
    public static int score  = 0;

    public static int totalscore = 0;

    public static TMPro.TMP_Text HighScore;
    public static TMPro.TMP_Text final;

    public static void AddScore(int v){
        Score.score += v;
    }


    public static void FinalScore(int curr){
        if(curr > Score.totalscore){
            Score.totalscore = curr;
            
            HighScore.text =  "NEW HIGH SCORE" + curr.ToString();
        }else{
            final.text = "Score: " + curr.ToString();
        }
    }
}
