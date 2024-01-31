using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject pin;
    List<GameObject> listOfSpawn = new List<GameObject>(10);
    public GameObject spawnPoint3;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < listOfSpawn.Count; i++)
        {
            //this declares the new gameObject with the name spawnPointi so it would incriment with the for loop making spawnPoint1 then spawnPoint2
            //it only makes new game objects not taking existing ones
            GameObject spawnPoint = new GameObject("SpawnPoint" + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(pin, listOfSpawn[0].transform);
        Debug.Log("Pin Spawned");
        
    }
}
