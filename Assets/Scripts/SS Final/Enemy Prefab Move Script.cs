using UnityEngine;

public class EnemyPrefabMoveScript : MonoBehaviour
{
    public float speed = 2;
    Vector3 randomPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 enemyPos = transform.position;

        randomPos = new Vector3(Random.Range(-18, 18), Random.Range(-18, 18));

        transform.position += randomPos * Time.deltaTime * speed;

        if (enemyPos.x < 9)
        {
            transform.position += randomPos * Time.deltaTime * speed * -1;
        }

        if (enemyPos.y < 9)
        {
            transform.position += randomPos * Time.deltaTime * speed *-1;
        }
    }
}
