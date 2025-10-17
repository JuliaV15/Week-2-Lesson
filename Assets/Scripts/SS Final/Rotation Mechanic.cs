using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class RotationMechanic : MonoBehaviour
{
    public Transform playerTarget;
    public float speed = 45f;
    public GameObject bulletPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 trackerUp = transform.up;
        Vector3 trackerPos = transform.position;

        Vector2 targetDirection = (playerTarget.position - transform.position).normalized;
        float dot = Vector3.Dot(transform.up, targetDirection);

        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg;
        float angle2 = Mathf.Atan2(trackerUp.y, trackerUp.x) * Mathf.Rad2Deg;

        float angle3 = Mathf.DeltaAngle(angle2, angle);

        float sign = Mathf.Sign(angle3);

        transform.Rotate(0, 0, speed * Time.deltaTime * sign);

        if (Input.GetKeyDown(KeyCode.P))
        {
            bullet();
        }
    }

    public void bullet()
    {
        Vector3 trackerPos = transform.position;
     //   Vector3 move = Vector3.up;
      //  Vector3 move2 = move.normalized;
      //  Vector3 bulletPos = bulletPrefab.transform.position;

      //  GameObject bullet = Instantiate(bulletPrefab, trackerPos, Quaternion.identity);
       // bullet.GetComponent<Part2RotationMech>().tracker = gameObject;

        Instantiate(bulletPrefab, trackerPos, transform.rotation); // transform.rotate sets the rotaion of the prefab to the rotation of the spawner
    }
}
