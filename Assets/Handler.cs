using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler : MonoBehaviour
{
    public bool CanEnter;
    [SerializeField]
    List<GameObject> items;
    List<string> itemNames = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        GenerateList();
    }
    public void GenerateList()
    {
        List<GameObject> addedObjects = new List<GameObject>();
        for(int i = 0; i <= 8; i++)
        {
            int index = Random.Range(0, items.Count);
            itemNames.Add("item" + index);
            GameObject spawnObject = items[index];
            addedObjects.Add(spawnObject);
        }
        gameObject.GetComponent<GenerateStuff>().GenerateObjects(addedObjects);
    }
    public void UpdateList()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
