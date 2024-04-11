using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] topRooms;
    [SerializeField] private GameObject[] bottomRooms;
    [SerializeField] private GameObject[] leftRooms;
    [SerializeField] private GameObject[] rightRooms;

    private Transform[] waypoints;

    void Update()
    {
        CheckSpawnpoints();
    }

    void CheckSpawnpoints()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Spawn Point");

        for (int i = 0; i < gameObjects.Length; i++)
        {
            Instantiate(leftRooms[Random.Range(0, leftRooms.Length - 1)]);
        }
    }
}
