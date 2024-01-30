using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public SpriteRenderer spriteR;

    public Sprite standingPin;
    public Sprite knockedPin;
    // Start is called before the first frame update
    void Start()
    {
        spriteR.sprite = standingPin;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteR.sprite = knockedPin;
    }
}
