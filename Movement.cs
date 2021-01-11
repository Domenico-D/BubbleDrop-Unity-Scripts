using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Vector2 startPosition;
    public Vector2 playerPosition;
    public static Vector2 speed;
    private Vector2 center;
    public Rigidbody2D body;
    public GameObject ball;

    public float slide;
    public float hVelocity;
    private float designWidth = 480.0f;
    public static float maxSpeed = ((0.5f * Screen.width) / 480.0f) * 5.0f;
    private float test = 0.5f * Screen.width;

    // Start is called before the first frame update
    void Start()
    {
        speed.x = 0.0f;
        speed.y = 0.0f;
        transform.position = startPosition;

   //     transform.position = Vector2.MoveTowards(playerPosition, startPosition, slide * Time.deltaTime);
        center.Set(0, 0);

        body = ball.GetComponent<Rigidbody2D>();


    }

    
    // Update is called once per frame
    void Update()
    {

        
        foreach (Touch touch in Input.touches)
        {
            if (touch.position.x < Screen.width / 2)
            {
                movement(true, false, false);
                
                body.AddForce(speed);

            }
            else if (touch.position.x > Screen.width / 2)
            {
                movement(false, true, false);
                
                body.AddForce(speed);
            }
            else
            {
                movement(false, false, true);
                
                body.AddForce(speed);
            }
        }

        


    }

    public void movement(bool left, bool right, bool stop)
    {

        if (right)
        {
            if(hVelocity <= maxSpeed)
            {
                hVelocity += test / designWidth;
            }
            else
            {
                hVelocity = maxSpeed;
            }
            

        }

        if (left)
        {
            if(hVelocity >= maxSpeed)
            {
                hVelocity -= test / designWidth;
            }
            else
            {
                hVelocity = -maxSpeed;
            }

        }

        if (stop)
        {

            if(hVelocity > 0)
            {
                hVelocity -= test / designWidth;
            }
            else if(hVelocity < 0)
            {
                hVelocity += test / designWidth;
            }

        }

        speed.x = hVelocity;

    }

}
