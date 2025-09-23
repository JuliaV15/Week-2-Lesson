using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public float enemyDistance;
    public float enemySpeed;

    private void Update()
    {
        EnemyMovement();
    }

    public void EnemyMovement()
    {
        Vector3 playerPos = player.transform.position;
        Vector3 enemyPos = new Vector3 (playerPos.x + enemyDistance, playerPos.y + enemyDistance);

        transform.position += playerPos * Time.deltaTime * enemySpeed/2;
    }

}
