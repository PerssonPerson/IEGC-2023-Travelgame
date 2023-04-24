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
        




    }

    static void newRound() 
    {
        roundNum++;

        if (roundNum % 2 == 0 && roundNum != 0 && roundNum! > 20) //Modulus Operator: true if roundNum is evenly divisible by 2. 20 is a temporary value 
        {






        }

    }

}
