using UnityEngine;
using System.Collections.Generic;

public class EnemyLines : MonoBehaviour
{
    public List<Vector3> enemyList;
    public float enemyAmount;
    public GameObject enemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemySpawning();
    }

    public void EnemySpawning ()
    {
        Vector3 enemyPos = new Vector3 (Random.Range(-18f, 18f), Random.Range(-18f, 18f));

        for (int i = 0; i < enemyAmount; i++)
        {
            Vector3 enemyPoint = enemyPos;

            enemyList.Add(enemyPoint);
        }
        // need to still add enemy movement and screen borders
       
        for (int i = 0; i < enemyList.Count; i++)
        {
            Instantiate(enemy, enemyPos, Quaternion.identity);

            Debug.DrawLine(enemyPos + enemyList[i], enemyPos + enemyList[i + 1], Color.red);
        }
    }
}
