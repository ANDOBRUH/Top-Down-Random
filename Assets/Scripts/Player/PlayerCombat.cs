using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public GameObject player;
    void Start()
    {

    }


    void Update()
    {
        lookAtMouse();
    }

    private void lookAtMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
        Vector2 direction = new Vector2(mousePosition.x, mousePosition.y);  

        transform.right = direction;
    }

}
