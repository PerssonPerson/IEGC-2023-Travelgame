using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainmovingcode : MonoBehaviour
{
    
    public float speed;
    int train;
    float timer;
    // Start is called before the first frame update
    void Start()

    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x < 0) //Makes the movement stop when x reaches a number lower than 0.
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        Invoke("DelayedMovementTrain", 20); //The amound of seconds delaying the actions below
    }
    private void DelayedMovementTrain()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime); //starts to move again after the seconds have passed
    }
    }

