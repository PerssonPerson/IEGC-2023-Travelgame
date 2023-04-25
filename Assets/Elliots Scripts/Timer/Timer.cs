using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    

    bool hasEnteredTrain;

    static float timer;

    public static float timeLimit;

    static TextMeshProUGUI timerText;

    static RawImage ticketIMG;

    static Color tempColor;

    static bool qOne;

    static bool qTwo;

    static bool qThree;

    static bool qFour;

    // Start is called before the first frame update
    void Start()
    {
        ElliotsMain.roundActive = true;

        timer = 60;

        timeLimit = 60;

        TicketShow(1);
    }

    // Update is called once per frame
    void Update()
    {

        if (ElliotsMain.roundActive) 
        {
            timer -= Time.deltaTime;
        }

        
        if (timer <= timeLimit * 0.75f && !qOne) 
        {


            TicketShow(2);
            TicketHide(1);

            qOne = true;


        }

        if (timer <= timeLimit * 0.5f && !qTwo)
        {


            TicketShow(3);
            TicketHide(2);

            qTwo = true;
        }

        if (timer <= timeLimit * 0.25f && !qThree)
        {


            TicketShow(4);
            TicketHide(3);

            qThree = true;
        }

        if (timer <= 0 && !qFour)
        {

            TicketHide(4);

            qFour = true;

        }

        if (hasEnteredTrain) //in main
        {
        
            //win();
        
        }

        /*if(timer <= 0) 
        {

            Defeat();
        
        }*/

        ShowTime();

    }

   public static void ResetTimer() 
    {

        timer = timeLimit;

        qOne = false;

        qTwo = false;

        qThree = false;

        qFour = false;
    }

    static void TicketShow(int ticketNum) 
    {

        ticketIMG = GameObject.Find("Ticket" + ticketNum).GetComponent<RawImage>();

        tempColor = ticketIMG.color;

        tempColor.a = 1;

        ticketIMG.color = tempColor;
    }

    static void TicketHide(int ticketNum)
    {

        ticketIMG = GameObject.Find("Ticket" + ticketNum).GetComponent<RawImage>();

        tempColor = ticketIMG.color;

        tempColor.a = 0;

        ticketIMG.color = tempColor;
    }

    static void ShowTime() 
    {


        timerText = GameObject.Find("Timer").GetComponent<TextMeshProUGUI>();

        

        timerText.text = timer.ToString("F2");
    }

    public static void Defeat()
    {
        ElliotsMain.EndRound();

        SceneManager.LoadScene("Defeat");

    }

}
