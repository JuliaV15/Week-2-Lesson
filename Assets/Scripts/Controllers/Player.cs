using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public List<Transform> asteroidTransforms;
    public int inNumberOfBombs;
    public float inBombSpacing;
    public float InDistance;
    public float ratio;
    public int inMaxRange;
    public float speed;
    public float accelerationTime = 3.0f;
    private Vector3 velocity = Vector3.zero;

    public float radius = 1;
    public List<Vector3> circlePoints = new();
    public int pointNumber = 9;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.B))
        {
            SpawnBombAtOffset(new Vector3(0, 1));
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            SpawnBombTrail(inBombSpacing, inNumberOfBombs);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SpawnBombOnRandomCorner(InDistance);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            WarpPlayer(enemyTransform, ratio);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            DetectAsteroids(inMaxRange, asteroidTransforms);
        }

        PlayerMovement();
       // EnemyRadar(angle);
    }

    private void SpawnBombAtOffset(Vector3 inOffset)
    {
        Vector3 spawnPos = transform.position + inOffset;
        Instantiate(bombPrefab, spawnPos, Quaternion.identity);
    }

    public void SpawnBombTrail(float inBombSpacing, int inNumberOfBombs)
    {
        Vector3 spawnPos = new Vector2(5, 5);
       // inBombSpacing = spawnPos.sqrMagnitude;
       Vector2 bombspace = new Vector2(spawnPos.x, spawnPos.y + inBombSpacing);

        for (int i = 0; i < inNumberOfBombs; i++) // i++ means that ot will add by 1 each time, i < inNumberOfBombs means that it //
                                                  // will keep doing the for loop until it reaches the variable inNumberOfBombs //
        {
            Instantiate(bombPrefab, (bombspace), Quaternion.identity);
        }
        
    }

    public void SpawnBombOnRandomCorner (float InDistance)
    {
        float distance = 4 * InDistance;
        float distance2 = 6 * InDistance;
        Vector2 glob = new Vector2(distance, distance2);
        Instantiate(bombPrefab, glob , Quaternion.identity);
    }

    public void WarpPlayer (Transform target, float ratio)
    {
        Vector3 a = transform.position;
        Vector3 b = target.transform.position;
        a = Vector3.Lerp(a, b, ratio); //idk what's wrong with this one, i thought it would work
    }

    public void DetectAsteroids (float inMaxRange, List <Transform> inAsteroids)
    {
        for (int i = 0; i < inMaxRange; i++)
        {
            Vector2 start = transform.position;
           // Vector2 end = inAsteroids.transform.position;
          //  Debug.DrawLine(start, end, Color.white);
        }
    }

    public void PlayerMovement ()
    {
        float acceleration = speed / accelerationTime;
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // transform.position += Vector3.up * Time.deltaTime * speed;
            velocity += acceleration * Time.deltaTime * Vector3.up;
           
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // transform.position += acceleration * Vector3.down * Time.deltaTime;
            // velocity += transform.position * Time.deltaTime;
            velocity += acceleration * Time.deltaTime * Vector3.down;
            
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            velocity += acceleration * Time.deltaTime * Vector3.left;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            velocity += acceleration * Time.deltaTime * Vector3.right;
        }

        // deaccceleration code starts here (i was getting confused)//
        float deaccelerationSpeed = 0;

        if (!Input.GetKey(KeyCode.UpArrow)) // ! means not, so in this case I am saying if the key is NOT up then this thing happens
        {
            velocity += deaccelerationSpeed * Time.deltaTime * Vector3.down;
        }

        if (!Input.GetKeyUp(KeyCode.DownArrow))
        {
            velocity += deaccelerationSpeed * Time.deltaTime * Vector3.up;
        }

        if (!Input.GetKeyUp(KeyCode.LeftArrow))
        {
            velocity += deaccelerationSpeed * Time.deltaTime * Vector3.right;
        }

        if (!Input.GetKeyUp(KeyCode.RightArrow))
        {
            velocity += deaccelerationSpeed * Time.deltaTime * Vector3.left;
        }

        velocity = Vector3.ClampMagnitude(velocity, speed);
        transform.position += velocity * Time.deltaTime;
    }

    public void EnemyRadar(float angle)
    {
        for (int i = 0; i < pointNumber; i++)
        {
          // Vector3 point = new Vector3()
            
           // circlePoints.Add(); // need to add a vector here bcz i changed list type from float to vector3 so using "i" doesnt work anymore in this context

        }
        
        Vector3 playerPos = transform.position;

        for (int i = 0;i < circlePoints.Count;i++)
        {
            Debug.DrawLine(playerPos + circlePoints[i], playerPos + circlePoints[i + 1], Color.green);
        }

     //   float radians = angle * Mathf.Deg2Rad;
      //  return new Vector3(Mathf.Cos(radians), Mathf.Sin(radians)) * radius;

        // Vector3 circlePointTest = new Vector3(Random.Range(-18f, 18f), Random.Range(-18f, 18f));
        //  Vector3.ClampMagnitude(circlePointTest, radius);
        // Debug.Log(circlePointTest);
        //  Debug.DrawLine(playerPos, circlePointTest, Color.green);
    }
}
