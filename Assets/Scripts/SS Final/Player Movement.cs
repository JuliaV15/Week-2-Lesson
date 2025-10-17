using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float accelerationTime = 3.0f;
    private Vector3 velocity;
    public float acceleration;
    public float decelerationTime = 3.0f;
    public float deceleration;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        acceleration = speed / accelerationTime;
        deceleration = speed / accelerationTime;
    }

    // Update is called once per frame
    void Update()
    {
        playerMove();
    }

    public void playerMove()
    {
        Vector2 playerInput = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //velocity += acceleration * Time.deltaTime * Vector3.up;
            playerInput += Vector2.up;

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
           // velocity += acceleration * Time.deltaTime * Vector3.down;
            playerInput += Vector2.down;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
           // velocity += acceleration * Time.deltaTime * Vector3.left;
            playerInput += Vector2.left;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            // velocity += acceleration * Time.deltaTime * Vector3.right;
            playerInput += Vector2.right;
        }

       // velocity = Vector3.ClampMagnitude(velocity, speed);
       // transform.position += velocity * Time.deltaTime;

        if (playerInput.magnitude > 0)
        {
            velocity += (Vector3)playerInput.normalized * acceleration * Time.deltaTime;

            if (velocity.magnitude > speed)
            {
                velocity = velocity.normalized * speed;
            }
        }
        else
        {
            Vector3 velocityChange = velocity.normalized * deceleration * Time.deltaTime; // storing the change in velocity using vector3

            if (velocityChange.magnitude > velocity.magnitude) //is the magnitude of velocity change bigger than magnitude of velocity
            {
                velocity = Vector3.zero; //make ship stop
            }
            else
            {
                velocity -= velocityChange; //if not, then we will do the velocity subtraction
            }

           // velocity -= velocity.normalized* deceleration *Time.deltaTime; we did not use this because if we stop pushing the arrow keys then the ship will start to go in the opposite direction
        }

        transform.position += velocity * Time.deltaTime;
    }
}
