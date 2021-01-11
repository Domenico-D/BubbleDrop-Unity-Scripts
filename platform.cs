using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{

    private Rigidbody2D rb;
    private float direction;
    private Vector2 speed;
    private Vector2 screenBounds;
    private Vector2 ballStart;
   



    // Start is called before the first frame update
    void Start()
    {
        ballStart.x = 0;
        ballStart.y = 3;





        //Instantiate rigidbody
        rb = this.GetComponent<Rigidbody2D>();

        //Set Speed values for both x and y vectors
        speed.x = 1.5f;
        speed.y = -1f;

        //1 and 0.5 or 0 and 10
        direction = Random.Range(0.0f, 10.0f);



        //Randomize origin direction of platform
        if (direction > 5.0f)
        {
            speed.x *= -1;
        }
        //Get the size of the screen
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));


    }

    // Update is called once per frame
    void Update()
    {
        //Set the velocity of the platform to determine speed
        rb.velocity = speed;



        //Destroy object after it leaves screen 
        if (transform.position.y < -screenBounds.y)
        {
            Destroy(this.gameObject);

        }

        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Check what object platform collides with and switch direction
        if(collision.tag.Equals( "MainCamera"))
        {
            speed.x *= -1;
        }

        if (collision.tag.Equals("score"))
        {
            Score.scoreValue++;
        }
        
        
    }

}
