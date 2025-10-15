using UnityEngine;

public class Part2RotationMech : MonoBehaviour
{
    public float rotateSpeed = 45f;
    public float moveSpeed = 2f;
    public GameObject tracker;
   // private Vector3 velo = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bulletPos = transform.position;
        
        transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
        transform.position = transform.position + new Vector3(moveSpeed * Time.deltaTime, moveSpeed * Time.deltaTime);

        //Vector3 bulletPos = transform.position;
        
        Vector3 bulletUp = transform.up;
        Vector3 bulletDown = transform.up * -1;
        Vector3 bulletRight = transform.right;
        Vector3 bulletLeft = transform.right * -1;

        //  transform.position += velo * Time.deltaTime * moveSpeed;
        // velo += moveSpeed * Time.deltaTime * Vector3.up;
        Destroy(gameObject, 3);
    }
}
