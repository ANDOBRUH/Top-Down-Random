using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.VisualScripting;
using UnityEngine;

public class CenterRayCast : MonoBehaviour
{
    private bool hitCenter = false;
    private bool hitWall = false;
    public GameObject blockRoom;
    void Start()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.up) * 10f, Color.red);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.left) * 10f, Color.red);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.right) * 10f, Color.red);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.down) * 10f, Color.red);

        RaycastHit2D hitUp = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 10f);
        RaycastHit2D hitDown = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), 10f);
        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.left), 10f);
        RaycastHit2D hitRight = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), 10f);

        if (hitUp || hitDown|| hitLeft|| hitRight)
        {
            if (hitUp.collider.tag == "Center" || hitDown.collider.tag == "Center" || hitLeft.collider.tag == "Center" || hitRight.collider.tag == "Center")
            {
                hitCenter = true;
            }
        }
       


        if (hitUp.collider.tag == "Wall" || hitDown.collider.tag == "Wall" || hitLeft.collider.tag == "Wall" || hitRight.collider.tag == "Wall")
        {
            hitWall = true;
        }

        if (hitCenter)
        {
            Instantiate(blockRoom, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
