using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterArrow : MonoBehaviour
{
    public SpriteRenderer spriteR;
    // Start is called before the first frame update
    void Start()
    {
        //spriteR.GetComponent<SpriteRenderer>();
        spriteR.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider other)
    {
        spriteR.color = Color.red;
    }
    private void OnTriggerExit2D(Collider other)
    {
        spriteR.color = Color.yellow;
    }
}
