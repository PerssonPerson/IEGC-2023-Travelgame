using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{

    string itemCollided;

    List<string> items = new List<string>();




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

    List<string> itemsNeeded;


    // Start is called before the first frame update
    void Start()
    {
        items.Add("Item0");

        items.Add("item1");

        items.Add("Item2");

        items.Add("item3");

        items.Add("Item4");

        items.Add("item5");

        items.Add("Item6");

        items.Add("item7");

        items.Add("Item8");

        itemsNeeded = new List<string>();

        itemsNeeded.Add("item2");

        itemsNeeded.Add("Item4");

        itemsNeeded.Add("item5");

        itemsNeeded.Add("Item8");

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

            itemCollided = collision.gameObject.name;

            itemsNeeded.Remove(itemCollided);

            Destroy(collision.gameObject);

        }

    }
}
