using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchColor : MonoBehaviour
{
    static int WHITE;
    static int YELLOW;
    static int GREEN;
    static int BLUE;

    void Start()
    {
        WHITE = LayerMask.NameToLayer("Default");
        YELLOW = LayerMask.NameToLayer("Yellow");
        GREEN = LayerMask.NameToLayer("Green");
        BLUE = LayerMask.NameToLayer("Blue");
    }

    void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            int color = gameObject.layer;

            if (color == WHITE || color == YELLOW)
            {
                color = GREEN;
                //GetComponent<MeshRenderer>().material = 
            }
            else if (color == GREEN)
            {
                color = BLUE;
            }
            else if (color == BLUE)
            {
                color = YELLOW;
            }

            gameObject.layer = color;
        }
	}
}
