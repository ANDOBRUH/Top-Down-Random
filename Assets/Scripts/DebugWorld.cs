using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugWorld : MonoBehaviour
{
    public bool ShowBlackBoxes;
    private GameObject[] blackBoxes;
    private SpriteRenderer[] blackBoxesSprite;
   
    void Update()
    {
        ActivateBlackBoxes();
    }

    private void ActivateBlackBoxes()
    {
        blackBoxes = GameObject.FindGameObjectsWithTag("Black Out");
        for (int i = 0; i < blackBoxes.Length; i++)
        {
            blackBoxesSprite[i] = blackBoxes[i].GetComponent<SpriteRenderer>();
        }

        if (ShowBlackBoxes)
        {
            for (int i = 0; i < blackBoxes.Length; i++)
            {              
                blackBoxesSprite[i].color = new Color(0, 0, 0, 255);
            }
        }
        else if (!ShowBlackBoxes)
        {
            for (int i = 0; i < blackBoxes.Length; i++)
            {             
                blackBoxesSprite[i].color = new Color(0, 0, 0, 0);
            }
        }
    }
}
