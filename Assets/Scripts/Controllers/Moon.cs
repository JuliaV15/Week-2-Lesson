using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform planetTransform;
    public GameObject orbitalSystem;

    public List<Vector3> orbitCircle;
    public float radius;
    public float speed;
    public float orbitCircleNumber = 9;
    public float angle = 45.0f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        OrbitalMotion(radius, speed, target);
    }

    public void OrbitalMotion(float radius, float speed, Transform target)
    {
        orbitCircle = new();

        float radians = angle * Mathf.Deg2Rad;

        Vector3 target2 = target.transform.position;

        for (int i = 0; i < orbitCircleNumber; i++)
        {
            Vector3 point = new Vector3(Mathf.Cos(i * radians) * radius, Mathf.Sin(i * radians) * radius);

            orbitCircle.Add(point);
        }

        for (int i = 0; i < orbitCircle.Count; i++)
        {
            transform.position += orbitCircle[i] * Time.deltaTime * speed;
            //Debug.DrawLine(playerPos + orbitCircle[i], playerPos + orbitCircle[i + 1], Color.green);
        }
    }
}
