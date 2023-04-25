using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ElliotsMain : MonoBehaviour
{
    static int roundNum;

    public static bool roundActive;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E)) //placeholder for enter train
       {

            NewRound();

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
        
            

        }

        if (Input.GetKeyDown(KeyCode.T)) //placeholder for time is out
        {

            Timer.Defeat();

        }

        if (Input.GetKeyDown(KeyCode.R)) 
        {

            //ItemSystem.Restart();
        
        }

    }

    static void NewRound() 
    {
        roundActive = false;



        

        roundNum++;

        if (roundNum % 2 == 0 && roundNum != 0 && roundNum! > 20) //Modulus Operator: true if roundNum is evenly divisible by 2. 20 is a temporary value 
        {


            Timer.timeLimit -= 2;


        }


        roundActive = true;
    }

    public static void EndRound() 
    {

        Timer.ResetTimer();


        roundActive = false;
    }


}
