using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Asteroid : MonoBehaviour
{
    public float moveSpeed;
    public float arrivalDistance;
    public float maxFloatDistance;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        AsteroidMovement();
    }

    public void AsteroidMovement()
    {
        Vector3 asteroidPos = transform.position;
        float asteroidMagnitude = MethodExamples.GetMagnitude(asteroidPos);

        Vector3 random = new Vector3 (Random.Range(-18, 18), Random.Range(-18, 18));
        Vector3.ClampMagnitude(random, maxFloatDistance);
        Debug.Log(random);

        //Vector3 randomPos = new Vector3(asteroidPos.x + maxFloatDistance, asteroidPos.y + maxFloatDistance);
        //Debug.Log(randomPos);

        //float randomMagnitude = MethodExamples.GetMagnitude(randomPos);
        
        Vector3 middleMan = asteroidPos - random; 
        Vector3 middle = middleMan.normalized;

        transform.position += middle * Time.deltaTime * moveSpeed;

        Vector3 arrival = middleMan - asteroidPos;
        Vector3 arrivalNormal = arrival.normalized;
        //Vector3 middle2 = asteroidPos - arrivalDistance;

        //if (asteroidPos = arrivalNormal)
        {

        }
    }
}
