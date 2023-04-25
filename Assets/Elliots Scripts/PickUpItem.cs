using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUpItem : MonoBehaviour
{





    /*string[] items = new string[]
    {
        "Item0",
        "Item1",
        "Item2",
        "Item3",
        "Item4",
        "Item5",
        "Item6",
        "Item7",
        "Item8",
    };*/

   

    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {



    }
    void OnCollisionEnter(Collision collision)
    {

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Item")
        {

            ItemSystem.PickUp(collision.gameObject.name);

            Destroy(collision.gameObject);

        }

    }
}
