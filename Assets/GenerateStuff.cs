using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStuff : MonoBehaviour
{
    [SerializeField]
    GameObject Platform;
    bool[] OccupiedTiles;
    [SerializeField]
    List<GameObject> Objects = new List<GameObject>();
    [SerializeField]
    float SpawnChance;
    // Start is called before the first frame update
    void Start()
    {
        OccupiedTiles = new bool[(int)((Platform.transform.localScale.x / 1.5f) * (Platform.transform.localScale.z / 1.5f))];
        for (int i = 0; i < (int)((Platform.transform.localScale.x / 1.5f) * (Platform.transform.localScale.z / 1.5f)); i++)
        {
            OccupiedTiles[i] = false;
        }
        Generate(Objects, SpawnChance);
        Generate(Objects, SpawnChance);

    }
    void Generate(List<GameObject> List, float chance)
    {
        int platformX = (int)((Platform.transform.localScale.x / 1.5f));
        int platformZ = (int)(Platform.transform.localScale.z / 1.5f);
        for (int x = 0; x < platformX; x++)
        {
            for (int z = 0; z < platformZ; z++)
            {
                chance = Random.Range(0f, 1f);
                if (chance < SpawnChance && !OccupiedTiles[z + x * platformZ])
                {
                    for (int x2 = -1; x2 < 2; x2++)
                    {
                        for (int z2 = -1; z2 < 2; z2++)
                        {

                            if ((z + z2 + (x + x2) * platformZ) < OccupiedTiles.Length && (z + z2 + (x + x2) * platformZ) >= 0)
                            {
                                OccupiedTiles[(z + z2 + (x + x2) * platformZ)] = true;
                            }
                        }
                    }
                    GameObject instance = GameObject.Instantiate(List[Random.Range(0, List.Count)]);
                    instance.transform.position = new Vector3((Platform.transform.localScale.x / 2) * -1 + x * 1.5f + instance.transform.localScale.z / 2, 0.5f + instance.transform.localScale.y / 2, (Platform.transform.localScale.z / 2) * -1 + z * 1.5f + instance.transform.localScale.z / 2);
                    instance.transform.parent = this.gameObject.transform;
                }
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
