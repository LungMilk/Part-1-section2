using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject pin;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Transform[] spawnPoints = FindObjectsOfType<Transform>();
        for (int i = 0; i < 10; i++)
        {
            Instantiate(pin, spawnPoints[i]);
            Debug.Log("Pin Spawned");
        }
       
    }
}
