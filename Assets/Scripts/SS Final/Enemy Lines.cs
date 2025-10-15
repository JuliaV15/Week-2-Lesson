using UnityEngine;
using System.Collections.Generic;

public class EnemyLines : MonoBehaviour
{
    public List<Vector3> enemyList;
    public float enemyAmount;
    public GameObject enemy;
    Vector3 enemyPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            EnemySpawning();
        }

        lineDrawing();
    }

    public void EnemySpawning ()
    {
      enemyPos = new Vector3 (Random.Range(-9f, 9f), Random.Range(-9f, 9f));

        for (int i = 0; i < enemyAmount; i++)
        {
            Vector3 enemyPoint = enemyPos;

            enemyList.Add(enemyPoint);
        }
        // need to still add enemy movement and screen borders
       
        for (int i = 0; i < enemyList.Count; i++)
        {
            Instantiate(enemy, enemyPos, Quaternion.identity);
        }
    }

    public void lineDrawing()
    {
      if (enemyList.Count > 0)
        {
            for (int i = 0; i < enemyList.Count; i++)
            {
                Debug.DrawLine(enemyList[i], enemyList[i + 1], Color.red);
            }
        }
       
    }
}
