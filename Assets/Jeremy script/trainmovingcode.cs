using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainmovingcode : MonoBehaviour
{
    
    public float speed;
    int train;
   
    // Start is called before the first frame update
    void Start()

    {
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x < 0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

        }
        //transform.position = new Vector3(0, 0, 2) * Time.deltaTime;
    }
    
    
    }

