using UnityEngine;

public class Part2RotationMech : MonoBehaviour
{
    public float rotateSpeed = 45f;
    public float moveSpeed = 50f;
    public GameObject tracker;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);

        Vector3 bulletPos = transform.position;
        
        Vector3 bulletUp = transform.up;
        Vector3 bulletDown = transform.up * -1;
        Vector3 bulletRight = transform.right;
        Vector3 bulletLeft = transform.right * -1;

       
    }
}
