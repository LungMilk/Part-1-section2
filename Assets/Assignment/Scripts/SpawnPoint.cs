using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject pin;
    public Transform spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pin, spawnpoint);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
