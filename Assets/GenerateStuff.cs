using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class GenerateStuff : MonoBehaviour
{
    [SerializeField]
    Vector2[] Vectors;
    [SerializeField]
    GameObject Platform;
    bool[] OccupiedTiles;
    [SerializeField]
    List<GameObject> Obstacles = new List<GameObject>();
    [SerializeField]
    List<GameObject> items = new List<GameObject>();
    [SerializeField]
    float SpawnChance;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void GenerateObjects(List<GameObject> Objects)
    {
        Vectors = new Vector2[(int)((Platform.transform.localScale.x / 1.5f) * (Platform.transform.localScale.z / 1.5f))];
        OccupiedTiles = new bool[(int)((Platform.transform.localScale.x / 1.5f) * (Platform.transform.localScale.z / 1.5f))];
        int platformX = (int)((Platform.transform.localScale.x / 1.5f));
        int platformZ = (int)(Platform.transform.localScale.z / 1.5f);
        for (int i = 0; i < (int)((Platform.transform.localScale.x / 1.5f) * (Platform.transform.localScale.z / 1.5f)); i++)
        {
            OccupiedTiles[i] = false;
        }
        for (int x = 0; x < platformX; x++)
        {
            for (int z = 0; z < platformZ; z++)
            {
                Vectors[z + x * platformZ] = new Vector2(x, z);
            }
        }
        int[] indexes = new int[Objects.Count];
        var rnd = new System.Random();
        var randomNumbers = Enumerable.Range(0, OccupiedTiles.Length -1).OrderBy(x => rnd.Next()).Take(Objects.Count).ToList();
        for (int i = 0; i < randomNumbers.Count; i++)
        {
            OccupiedTiles[randomNumbers[i]] = true;
            GameObject instance = Instantiate(Objects[i]);
            instance.transform.position = new Vector3((Platform.transform.localScale.x / 2) * -1 + Vectors[randomNumbers[i]].x * 1.5f + instance.transform.localScale.z / 2, 0.5f + instance.transform.localScale.y / 2, (Platform.transform.localScale.z / 2) * -1 + Vectors[randomNumbers[i]].y * 1.5f + instance.transform.localScale.z / 2);
        }
        Generate(Obstacles, SpawnChance);
    }
    void Generate(List<GameObject> List, float chance)
    {
        int platformX = (int)((Platform.transform.localScale.x / 1.5f));
        int platformZ = (int)(Platform.transform.localScale.z / 1.5f);
        for (int x = 0; x < platformX; x++)
        {
            for (int z = 0; z < platformZ; z++)
            {
                chance = UnityEngine.Random.Range(0f, 1f);
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
                    GameObject instance = GameObject.Instantiate(List[UnityEngine.Random.Range(0, List.Count)]);
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
