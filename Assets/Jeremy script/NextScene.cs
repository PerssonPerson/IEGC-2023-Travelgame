using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextScene : MonoBehaviour
{

    //OBS This code goes onto the player and not the train.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x > 39) //if the game objects x position has reached position x 39 it will transfer us to the next scene.
        {
            SceneManager.LoadScene("TestSceneLoad"); //Choose which scene it goes to
        }
    }
}
