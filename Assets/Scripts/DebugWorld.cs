using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugWorld : MonoBehaviour
{
    public bool ShowBlackBoxes;
    private GameObject[] blackBoxes;
   
    void Update()
    {
        ActivateBlackBoxes();
    }

    private void ActivateBlackBoxes()
    {
        blackBoxes = GameObject.FindGameObjectsWithTag("Black Out");

        if (ShowBlackBoxes)
        {
            for (int i = 0; i < blackBoxes.Length; i++)
            {
                blackBoxes[i].SetActive(true);
                Debug.Log("hwedhbsi");
            }
        }
        else if (!ShowBlackBoxes)
        {
            for (int i = 0; i < blackBoxes.Length; i++)
            {
                blackBoxes[i].SetActive(false);
            }
        }
    }
}
