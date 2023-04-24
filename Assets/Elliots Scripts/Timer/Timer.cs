using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    

    bool hasEnteredTrain;

    static float timer;

    public static float timeLimit;

    static TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        ElliotsMain.roundActive = true;

        timer = 60;

        timeLimit = 60;
        

    }

    // Update is called once per frame
    void Update()
    {

        if (ElliotsMain.roundActive) 
        {
            timer -= Time.deltaTime;
        }

        if (hasEnteredTrain) //in main
        {
        
            //win();
        
        }

        if(timer <= 0) 
        {

            Defeat();
        
        }

        showTime();

    }

   public static void resetTimer() 
    {

        timer = timeLimit;




    }

    static void showTime() 
    {


        timerText = GameObject.Find("Timer").GetComponent<TextMeshProUGUI>();

        

        timerText.text = timer.ToString("F2");
    }

    static void Defeat()
    {
        SceneManager.LoadScene("Defeat");

    }

}
