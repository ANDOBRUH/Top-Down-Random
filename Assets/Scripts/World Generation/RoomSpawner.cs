using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawner : MonoBehaviour
{
    public int openingDirection;
    // 1 = top
    // 2 = bottom
    // 3 = left
    // 4 = right
    public GameObject dubbleSpawnCheck;
    private DungeonTemplate templates;
    private int random;
    public bool spawned = false;

    private void Start()
    {
        templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<DungeonTemplate>();
        Invoke("Spawn", 0.1f);
    }

    void Spawn()
    {
        if (spawned == false)
        {
            if (openingDirection == 1)
            {
                random = Random.Range(0, templates.topRooms.Length);
                Instantiate(templates.topRooms[random], transform.position, Quaternion.identity);
            }
            else if (openingDirection == 2)
            {
                random = Random.Range(0, templates.bottomRooms.Length);
                Instantiate(templates.bottomRooms[random], transform.position, Quaternion.identity);
            }
            else if (openingDirection == 3)
            {
                random = Random.Range(0, templates.leftRooms.Length);
                Instantiate(templates.leftRooms[random], transform.position, Quaternion.identity);
            }
            else if (openingDirection == 4)
            {
                random = Random.Range(0, templates.rightRooms.Length);
                Instantiate(templates.rightRooms[random], transform.position, Quaternion.identity);
            }
        }
        spawned = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spawn Point") || other.CompareTag("Center"))
        {
            Destroy(gameObject);
        }


        if (other.CompareTag("Spawn Point"))
        {
            Instantiate(dubbleSpawnCheck, transform.position, Quaternion.identity);
        }
    }

    private void Update()
    {
        if (spawned)
        {
            Destroy(gameObject);
        }
    }
}
