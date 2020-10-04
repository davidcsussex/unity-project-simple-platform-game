using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    // Start is called before the first frame update

    public int lives = 1;
    bool faceLeft=false;    
    private Rigidbody2D rb;
    

    
    void Start()
    {
        // Get the rigidbody component
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;

        // make player jump
        if (Input.GetKey("j"))
        {
            if( velocity.y == 0 )
            velocity.y=12;
        }
        

        
        
        
        // move player left/right
        if (Input.GetKey("left"))
        {
            // registers a key held down and returns true
            velocity.x = -8.0f;
            faceLeft = true;
        }
        else if (Input.GetKey("right"))
        {
            // registers a key held down and returns true
            velocity.x = 8;
            faceLeft = false;
        
        }
        else
        {
            velocity.x=0;
        }


        // copy velocity values into the player RigidBody   
        rb.velocity = velocity;

        // set the player to face in the correct direction
        if( faceLeft == true )
        {
            
            transform.localScale = new Vector3(-1,1,1);
        }
        else
        {
            
            transform.localScale = new Vector3(1,1,1);
        }

        

        //ui_text.Debug("hello");

    }
}
