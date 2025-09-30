using UnityEngine;
using System.Collections.Generic;

public class PowerUps : MonoBehaviour
{
    [Header("Power Up Spawning")]
    public List<Vector3> powerUpSpawnPoint;
    public float radius = 1;
    public int spawnPointNumber;
    public GameObject powerupPrefab;

    [Header("Power Up Ability - Teleportation")]
    public List<Vector3> Playertp;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            PowerUpSpawn(radius, spawnPointNumber);
        }

        PlayerTeleportation();
    }

    public void PowerUpSpawn (float radius, int spawnPointNumber)
    {
        powerUpSpawnPoint = new();

        float nextSpawn = 360f / spawnPointNumber;
        float radians = nextSpawn * Mathf.Deg2Rad;

        for (int i = 0; i < spawnPointNumber; i++)
        {
            float adjustments = radians * i;

            Vector3 spawnpoint = new Vector3(Mathf.Cos(radians + adjustments) * radius * Mathf.Rad2Deg, Mathf.Sin(radians + adjustments) * radius * Mathf.Rad2Deg);

            powerUpSpawnPoint.Add(spawnpoint);
        }

        Vector3 shipPosition = transform.position;

        for (int i = 0; i < powerUpSpawnPoint.Count; i++)
        {
            Instantiate(powerupPrefab, shipPosition + powerUpSpawnPoint[i], Quaternion.identity);
            // this is temporary, i want the power ups to spawn at only 1 of these points, not at all of them
        }
    }

    public void PlayerTeleportation ()
    {
        Playertp = new();
    }
}
