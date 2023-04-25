using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class ItemSystem : MonoBehaviour
{
   static int imgX;

   static int imgY = 10;

    static List<string> items = new List<string>();

    static List<string> itemsNeeded;


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

        for (int i = 0; i <= 8; i++)
        {
            int amount = itemsNeeded.Where(x => x == "item" + i).ToList().Count;

            Vector2 imagePosition = new Vector2 (imgX, imgY);

            if (amount > 0)
            {

                ShowImage(amount, i, imagePosition);

            }


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void ShowImage(int amount, int imgNum, Vector2 imageXY) 
    {


    
        for(int i = 0; i <= amount; i++) 
        {

            //Instantiate(GameObject.FindObjectOfType<"imageitem" + imgNum>, imageXY, Quaternion.identity);

        
        }
    
    }

  public static void PickUp(string itemCollided) 
    {

        

        itemsNeeded.Remove(itemCollided);

        

    }
}
