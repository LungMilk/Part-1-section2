using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelRed : MonoBehaviour
{
    SpriteRenderer spriteRend;
    Rigidbody2D rig;
    public Sprite standingposition;
    public Sprite knockeddown;

    // Start is called before the first frame update
    void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
        spriteRend.sprite = standingposition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRend.sprite = knockeddown;
        Debug.Log("collision");
    }
}
