using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class UnitCircleValueExercise : MonoBehaviour
{
    public float radius = 1f;
    public Vector3 center = Vector3.zero;
    public List<float> angleList = new();

    [Space(10)]
    public float lineDuration = 1f;

    private float elapsedTime = 0f;
    private int currentIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0;  i < 10; i++)
        {
            angleList.Add(Random.value * 360f); // picking 10 random angles withtin given range (360 in this case)
        }
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
       
        if (Input.GetKeyDown(KeyCode.Space) || elapsedTime > lineDuration) // check if space down OR if elapsed time > line duration (essentially it auto changes every x amount of time but also if space is pressed)
        {
           elapsedTime = 0f;
           currentIndex = (currentIndex + 1) % angleList.Count;  // handy formula for wrapping around all the values of a list (looping over and over)
        }
        Vector3 point = GetPointOnUnitCircle(angleList[currentIndex]);

        Debug.DrawLine(center, center + point, Color.green);
    }

    private Vector3 GetPointOnUnitCircle(float angle)
    {
        float radians = angle * Mathf.Deg2Rad;
        return new Vector3(Mathf.Cos(radians), Mathf.Sin(radians)) * radius;
    }
}
