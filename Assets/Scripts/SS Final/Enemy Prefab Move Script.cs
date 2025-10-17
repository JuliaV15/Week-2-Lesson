using UnityEngine;

public class EnemyPrefabMoveScript : MonoBehaviour
{
    public float speed = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 enemyPos = transform.position;

        Vector3 random = new Vector3(Random.Range(-18, 18), Random.Range(-18, 18));

        Vector3 middleMan = enemyPos - random;
        Vector3 middle = middleMan.normalized;

        transform.position += middle * Time.deltaTime * speed;

        if (enemyPos.x < 9)
        {
            transform.position += middle * Time.deltaTime * speed * -1;
        }

        if (enemyPos.y < 9)
        {
            transform.position += middle * Time.deltaTime * speed *-1;
        }
    }
}
