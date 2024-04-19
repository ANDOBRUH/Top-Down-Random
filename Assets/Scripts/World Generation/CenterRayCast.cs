using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterRayCast : MonoBehaviour
{
    Ray ray;
    float maxDistance = 100;
    public LayerMask layersToHit;
    void Start()
    {
        ray = new Ray(transform.position, transform.up);
    }

    void Update()
    {
        
    }
}
