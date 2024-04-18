using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpecialRoomSpawner : MonoBehaviour
{
    private GameObject[] centers;
    private GameObject[] spawnPoints;
    public GameObject lvlRoom;
    public GameObject bossRoom;

    private int random;
    private bool spawned = false;

    private Vector3 roomSpawnPoint;

    void Update()
    {
        centers = GameObject.FindGameObjectsWithTag("Center");
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn Point");

        if (spawnPoints.Length == 0 && spawned == false)
        {
           random = Random.Range(0, centers.Length);
           roomSpawnPoint = centers[random].transform.position;
           Instantiate(lvlRoom, roomSpawnPoint, Quaternion.identity);
           
           random = Random.Range(0, centers.Length);
           roomSpawnPoint = centers[random].transform.position;
           Instantiate(bossRoom, roomSpawnPoint, Quaternion.identity);
           spawned = true;
        }
    }
}
