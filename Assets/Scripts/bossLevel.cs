using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;



public class bossLevel : MonoBehaviour
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

    [SerializeField] private ParticleSystem firework;
        [SerializeField] private ParticleSystem subemitter;

    private float timer = 10f;
    private float countdown;
    private bool gameOver = false;
    public InputActionReference triggerLeft;
    public InputActionReference triggerRight;





    void Start()
    {
        countdown = timer;

    }

    public void FinalScore(int curr)
    {
        if (curr > Score.totalscore)
        {
            Score.totalscore = curr;

            HighScore.text = "NEW HIGH SCORE:  " + curr.ToString();
        }
  
        final.text = "Score: " + curr.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        float leftTriggerValue = triggerLeft.action.ReadValue<float>();
        float rightTriggerValue = triggerRight.action.ReadValue<float>();

        if (leftTriggerValue > 0.5f && rightTriggerValue > 0.5f)
        {
            SceneManager.LoadScene("Scenes/MainScene");
            Score.score = 0;
            Score.totalscore = 0;

        }

        if (gameOver) return;

        if (countdown <= 0)
        {
            // get score and run it through the hiscore check
            countdown = 0;
            GameOver();
        }
        else
        {
            Debug.Log(Time.deltaTime);
            countdown -= Time.deltaTime;
            updatetimeDisplay();
            final.text = "Score: " + Score.score;
        }

    }

    void updatetimeDisplay()
    {
        displayTime.text = "Time: " + Mathf.CeilToInt(countdown).ToString();
    }

    void GameOver()
    {
        gameOver = true;
       // Time.timeScale = 0; 
        FinalScore(Score.score);
        Debug.Log("Game Over!");
        firework.Play();
        subemitter.Play();
       
        
    }
}
