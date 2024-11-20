//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//public class game : MonoBehaviour
//{

//    /*This is the code that controls the game when it starts
//    *What is needed for this code
//    *- A timer that decreases to 0 (done)
//    * when time = 0 stop the game and check for HiScore
//    *some way to start the game
//    *-Music goes here potentially?
//    */
    
//    // Start is called before the first frame update
//    private float timer = 60f;
//    private float countdown;
//    public static TMPro.TMP_Text displayTime;

//    public static TMPro.TMP_Text HighScore;
//    public static TMPro.TMP_Text final;

//    void Start()
//    {
//        timer = countdown;
//    }

//     public static void FinalScore(int curr){
//        if(curr > Score.totalscore){
//            Score.totalscore = curr;
            
//            HighScore.text =  "NEW HIGH SCORE" + curr.ToString();
//        }else{
//            final.text = "Score: " + curr.ToString();
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if(countdown <= 0){
//            // get score and run it through the hiscore check
//            countdown = 0;
//            Score.FinalScore(Score.score);
//        }else{
//            countdown -= Time.deltaTime;
//            updatetimeDisplay();
//        }

//    }

//    void updatetimeDisplay(){
//        displayTime.text = "Time: " + Mathf.CeilToInt(countdown).ToString();
//    }
//}
