using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PowerUpPrefabScript : MonoBehaviour
{
    [Header("Power Up Ability - Teleportation")]
    public List<Vector3> Playertp;
    public float radius = 0.25f;
    public float angle = 45f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerTeleportation();
    }

    public void PlayerTeleportation()
    {
        Playertp = new();

        float radarNumber = 9;

        Vector3 powerupPos = transform.position;

        float radians = angle * Mathf.Deg2Rad;

        for (int i = 0; i < radarNumber; i++)
        {
            Vector3 point = new Vector3(Mathf.Cos(i * radians) * radius, Mathf.Sin(i * radians) * radius);

            Playertp.Add(point);
        }

        for (int i = 0; i < Playertp.Count - 1; i++)
        {
            Debug.DrawLine(powerupPos + Playertp[i], powerupPos + Playertp[i + 1], Color.cyan);
        }
    }
}
