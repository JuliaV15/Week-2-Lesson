using UnityEngine;

public class DotProductExercise : MonoBehaviour
{
    public float redAngle = 45f;
    public float blueAngle = 60f;
    public float radius = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        float redradians = redAngle * Mathf.Deg2Rad;
        float blueradians = blueAngle * Mathf.Deg2Rad;

        Vector3 redVector = new Vector3 (Mathf.Cos(redradians), Mathf.Sin(redradians)) * radius;

        Vector3 blueVector = new Vector3(Mathf.Cos(blueradians), Mathf.Sin(blueradians)) * radius;

        Debug.DrawLine(Vector3.zero, redVector, Color.red);
        Debug.DrawLine(Vector3.zero, blueVector, Color.blue);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float dot = CalculateDotProduct(redVector, blueVector);
            Debug.Log($"<color=orange><size=16>{dot}</size></color>");
        }
    }

    private float CalculateDotProduct(Vector2 a, Vector2 b)
    {
        return a.x * b.x + a.y * b.y;
    }
}
