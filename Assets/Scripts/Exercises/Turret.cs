using UnityEngine;

public class Turret : MonoBehaviour
{
    public float angularSpeed = 50f;
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 triangleUp = transform.up;
        Vector3 trianglePos = transform.position;
        
        Debug.DrawLine(trianglePos, trianglePos + triangleUp, Color.green);

        Vector2 direction2target = (target.position - transform.position).normalized;
        float dot = Vector3.Dot(transform.up, direction2target);
        if (dot < 0) Debug.Log("behind");
        if (dot > 0) Debug.Log("in front");

        float angle = Mathf.Atan2(direction2target.y, direction2target.x) * Mathf.Rad2Deg;
        float angle2 = Mathf.Atan2(triangleUp.y, triangleUp.x) * Mathf.Rad2Deg;

        float triAngle = Mathf.DeltaAngle(angle2, angle);
        Debug.Log(triAngle);

        float sign = Mathf.Sign(triAngle);

        transform.Rotate(0, 0, angularSpeed * Time.deltaTime * sign); //it now rotates to track the "target"
    }
}
