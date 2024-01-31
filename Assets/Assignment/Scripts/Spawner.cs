using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pin;
<<<<<<< Updated upstream
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
=======
    Transform[] spawnPoints = FindObjectsOfType<Transform>();

    // Start is called before the first frame update
    void Start()
    {
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
<<<<<<< Updated upstream
        Instantiate(pin, spawnPoint);
        Debug.Log("Pin Spawned");
=======
        for (int i = 0; i < 10; i++)
        {
            Instantiate(pin, spawnPoints[i]);
            Debug.Log("Pin Spawned");
        }
>>>>>>> Stashed changes
        
    }
}
