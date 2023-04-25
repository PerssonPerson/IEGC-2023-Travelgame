using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;

public class ItemSystem : MonoBehaviour
{

    [SerializeField]
    Transform parent;


    static int imgX = 60;

   static int imgY = 600;

    //static List<string> items = new List<string>();

    static List<int> itemsNeeded;

    [SerializeField]
    List<GameObject> images;

    static Vector2 imagePosition = new Vector2(imgX, imgY);

    // Start is called before the first frame update
    void Start()
    {


        /*
                items.Add("Item0");

                items.Add("item1");

                items.Add("Item2");

                items.Add("item3");

                items.Add("Item4");

                items.Add("item5");

                items.Add("Item6");

                items.Add("item7");

                items.Add("Item8");
        */

        ShowUI();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShowUI()
    {
        itemsNeeded = new List<int>();


        itemsNeeded.Add(0);
        itemsNeeded.Add(0);

        itemsNeeded.Add(1);
        itemsNeeded.Add(1);

        itemsNeeded.Add(2);

        for (int i = 0; i < itemsNeeded.Count; i++)
        {
            //int amount = itemsNeeded.Where(x => x == "item" + i).ToList().Count;

            imagePosition.y -= 40;

            ShowImage(itemsNeeded[i], parent, images);




        }
    }
    static void ShowImage( int itemNum, Transform parent, List<GameObject> images) 
    {
        
        GameObject imageObject;
        



            

            imageObject = Instantiate(images[itemNum], imagePosition, Quaternion.identity);




            imageObject.transform.SetParent(parent);

       

        
    }
    
  public static void PickUp(string itemCollided) 
    {
        Destroy(GameObject.Find("image" + itemCollided + "(Clone)"));
        

        itemsNeeded.Remove(int.Parse(itemCollided.Split('_')[1]));

        Debug.Log(itemsNeeded);

    }

    /*public static void Restart() 
    {

        GameObject[] itemImages = GameObject.FindGameObjectsWithTag("ImgItem");

        foreach(GameObject item in itemImages) 
        {
            Destroy(item);
        
        }
        

    
    }*/
}
