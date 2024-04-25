using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.VisualScripting;
using UnityEngine;

public class CenterRayCast : MonoBehaviour
{
    private bool hitCenter = false;
    private bool hitNothing = false;
    private bool runScript = false;
    public GameObject blockRoom;
   
    void Update()
    {
        if (runScript)
       {
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.up) * 10f, Color.red);
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.left) * 10f, Color.red);
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.right) * 10f, Color.red);
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.down) * 10f, Color.red);

        //    RaycastHit2D hitUp = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), 10f);
        //    RaycastHit2D hitDown = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), 10f);
        //    RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.left), 10f);
        //    RaycastHit2D hitRight = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), 10f);

        //    if (hitUp || hitDown || hitLeft || hitRight)
        //    {
        //        if (hitUp.collider.tag == "Center" || hitDown.collider.tag == "Center" || hitLeft.collider.tag == "Center" || hitRight.collider.tag == "Center")
        //        {
        //            hitCenter = true;
        //        }
        //    }

        //    if (hitUp || hitDown || hitLeft || hitRight)
        //    {

        //        if (hitUp.collider.tag == "Untagged" || hitDown.collider.tag == "Untagged" || hitLeft.collider.tag == "Untagged" || hitRight.collider.tag == "Untagged")
        //        {
        //            hitNothing = true;
        //        }
        //    }
        //    Debug.Log("Up: " + hitUp.collider.tag + " Down: " + hitDown.collider.tag + " Left: " + hitLeft.collider.tag + " Right: " + hitRight.collider.tag);
            
           
            Instantiate(blockRoom, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }  
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Center"))
        {
            Destroy(gameObject);
        }
        else if (other.CompareTag("Dubbel Room"))
        {
            runScript = true;
            Debug.Log("Yuh");
        }
    }
}
