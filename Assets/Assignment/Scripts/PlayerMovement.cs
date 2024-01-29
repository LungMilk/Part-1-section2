using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    Vector2 direction;
    Rigidbody2D rigidB;
    public float force = 500;
    public float rotateSpeed = -500;
    

    // Start is called before the first frame update
    void Start()
    {
        //grabs the rigidbody from the object its attached to and assigns to rigidB
        rigidB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //sets direction. x/y to either 1 or -1 depending on the input form keyboard
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        //adds a force to the rigidBody2D to propel it
        //direction multiplys the force to either have it move positive or negative depending on the input
        rigidB.AddForce(force * direction * Time.deltaTime);
        //Move rotation rotates the object sprite while it moves with the direction it moves (revesed to imply rolling)
        rigidB.MoveRotation(rigidB.rotation + rotateSpeed * direction.x * Time.deltaTime);
    }
}
