using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class game : MonoBehaviour
{

    //    /*This is the code that controls the game when it starts
    //    *What is needed for this code
    //    *- A timer that decreases to 0 (done)
    //    * when time = 0 stop the game and check for HiScore
    //    *some way to start the game
    //    *-Music goes here potentially?
    //    */

    //    // Start is called before the first frame update
    public TMPro.TMP_Text displayTime;

    public TMPro.TMP_Text HighScore;
    public TMPro.TMP_Text final;

    private float timer = 60f;
    private float countdown;
    private bool gameOver = false;



    void Start()
    {
        countdown= timer;

    }

    public void FinalScore(int curr)
    {
        if (curr > Score.totalscore)
        {
            Score.totalscore = curr;

            HighScore.text = "NEW HIGH SCORE" + curr.ToString();
        }
        else
        {
            final.text = "Score: " + curr.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver) return;

        if (countdown <= 0)
        {
            // get score and run it through the hiscore check
            countdown = 0;
            GameOver();
        }
        else
        {
            countdown -= Time.deltaTime;
            updatetimeDisplay();
        }

    }

    void updatetimeDisplay()
    {
        displayTime.text = "Time: " + Mathf.CeilToInt(countdown).ToString();
    }

    void GameOver()
    {
        gameOver = true;
        Time.timeScale = 0; // Stop all physics and time-dependent updates
        FinalScore(Score.score);
        Debug.Log("Game Over!"); // You can also trigger other end-game UI elements here
    }
}
