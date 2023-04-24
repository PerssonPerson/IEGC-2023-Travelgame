using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    

    bool hasEnteredTrain;

    static float timer;

    

    static TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        ElliotsMain.roundActive = true;

        timer = 60;
        

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

        if(timer >= 0) 
        {
        
            //lose();
        
        }

        showTime();

    }

    static void showTime() 
    {


        timerText = GameObject.Find("Timer").GetComponent<TextMeshProUGUI>();

        

        timerText.text = timer.ToString("F2");
    }

}
