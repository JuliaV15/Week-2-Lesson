using NUnit.Framework.Internal;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public List<Transform> starTransforms;
    public float drawingTime;

    // Update is called once per frame
    void Update()
    {
        DrawConstellation();
    }
    public void DrawConstellation()
    {
       // test to see why duration of debug.drawline is not working and try to fix it //
        Vector3 dog = new Vector3(-10, 4.5f);
        Vector3 cat1 = new Vector3(-5.4f, 4);
        Debug.DrawLine(Vector3.zero, cat1, Color.blue, 2);

        // where actual code begins //
        float starNumber = starTransforms.Count();

        foreach (Transform starthings in starTransforms)
        {
            Debug.Log(starthings.position);
        }

        foreach (Transform stars in starTransforms)
        {
            // trying to work out code for how to make the drawing get drawn in a certain amount of time and to consecutively draw a line //
          //  Vector3 test0 = new Vector3(-10, 4.5f);
          //  Vector3 test1 = new Vector3(-5.4f, 4);
          //  Vector3 test2 = new Vector3(-3.2f, 1.2f);
          //  Vector3 test3 = new Vector3(-0.26f,-1.8f);
          //  Vector3 test4 = new Vector3(0.87f, -6);
           // Vector3 test5 = new Vector3(6.4f, -6);
           // Vector3 test6 = new Vector3(7, -1.9f);
            
            //Debug.DrawLine(test0, test1, Color.blue, 2);
          //  Debug.DrawLine(test1, test2, Color.blue);
           // Debug.DrawLine(test2, test3, Color.blue);
           // Debug.DrawLine(test3, test4, Color.blue);
           // Debug.DrawLine(test4, test5, Color.blue);
           // Debug.DrawLine(test5, test6, Color.blue);

            //where ACTUAL code begins //
            Debug.DrawLine(stars.position, stars.position, Color.white);

            for (int i = 0; i < starNumber; i++)
            {
                Debug.DrawLine(stars.position, stars.position, Color.white);
                Debug.Log("stars");
            }
        }
 
    }

}
