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
        Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        DrawRect(mousepos, Vector2.one, Color.red); // vector2.one is a short term for a vector that is (1, 1)

        print(Normalize(new Vector2(3, 4)));
        print(Normalize(new Vector2(-3, 2)));
        print(Normalize(new Vector2(1.5f, -3.5f)));
    }

    public static float GetMagnitude(Vector2 v)
    {
        return Mathf.Sqrt(Mathf.Pow(v.x, 2) + Mathf.Pow(v.y, 2));
    }

    public static void DrawRect(Vector2 pos, Vector2 size, Color color)
        {
        float halfWidth = size.x / 2;
        float halfHeight = size.y / 2;

        Vector2 topleft = new Vector2(pos.x - halfWidth, pos.y + halfHeight);
        Vector2 topright = topleft + Vector2.right * size.x; // vector2.right is a short term for a vector that is (1, 0)
        Vector2 bottomright = new Vector2(pos.x + halfWidth, pos.y + halfHeight);

        }

    private Vector2 Normalize(Vector2 v)
    {
        float magnitude = GetMagnitude(v);

        Vector2 normalized = new Vector2(v.x / magnitude, v.y / magnitude);
        return normalized;
    }
}
