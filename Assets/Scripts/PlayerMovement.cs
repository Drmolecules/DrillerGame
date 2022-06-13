using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    bool myBool = true;
    public float speed;
    public Rigidbody2D rb;
    
   
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        myBool = true;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Moving Object To The Right And Flipping To The Right
        if(myBool == true)
        {
            transform.position += new Vector3(speed, 0, 0 * Time.deltaTime);
            
            gameObject.transform.localScale = new Vector3(-0.7f, 0.7f, 0.7f);
            
           
            

        }
        
        // Moving Object To The Left And Flipping To The Left
        if(myBool == false)
        {
            transform.position += new Vector3(-speed, 0, 0 * Time.deltaTime);
           
            gameObject.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
           
           
            

        }

        
     
    }


    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            myBool = !myBool;

        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
