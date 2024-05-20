using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LoadInNew : MonoBehaviour
{
    private Vector3 spawnPosition = new Vector3(0, 0, 0);
    private GameObject[] rooms;
    private Transform Player;
    public GameObject entryRoom;
    public TextMeshProUGUI text;

    private void Start()
    {
        Player = gameObject.GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Boss Room"))
        {
            text.enabled = true;
            if (Input.GetKeyDown("f"))
            {
                rooms = GameObject.FindGameObjectsWithTag("Room Copys");
                for (int i = 0; i < rooms.Length; i++)
                {
                    Destroy(rooms[i]);
                }
                Instantiate(entryRoom, spawnPosition, Quaternion.identity);
                Player.transform.position = entryRoom.transform.position;
                text.enabled = false;
            }   
        }
    }
}
