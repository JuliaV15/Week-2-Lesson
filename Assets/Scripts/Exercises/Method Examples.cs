using UnityEditor;
using UnityEngine;

public class MethodExamples : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 vect = new Vector2(3, 4);
        Vector2 vect2 = new Vector2(8, 0);

        float magnitude = GetMagnitude(vect);
        float magnitude2 = GetMagnitude(vect2); // methods are useful here bc if we need to call a function multiple times we can
                                                // we usually try to have each function do one thing, helps simplify and organize. like you could lose track of what does what
                                                // and also if you're putting all your code in one function then what's the point of the function, just put the code in the void update

        print(magnitude);
        print(magnitude2); // print is pretty much exactly the same as debug.log
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    float GetMagnitude(Vector2 v)
    {
        return Mathf.Sqrt(Mathf.Pow(v.x, 2) + Mathf.Pow(v.y, 2));
    }
}
