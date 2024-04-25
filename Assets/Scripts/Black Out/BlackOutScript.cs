using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackOutScript : MonoBehaviour
{
    private bool show = true;
    void Update()
    {
        if (show)
        {
            GetComponent<SpriteRenderer>().material.color = new Color(0f, 0f, 0f, 255f);
        }
        else
        {
            GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            show = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            show = true;
        }
    }
}
