using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchColor : MonoBehaviour
{
    static int BLACK;
    static int YELLOW;
    static int GREEN;
    static int BLUE;

    MeshRenderer mr;

    public Material green;
    public Material yellow;
    public Material blue;

    void Start()
    {
        BLACK = LayerMask.NameToLayer("Black");
        YELLOW = LayerMask.NameToLayer("Yellow");
        GREEN = LayerMask.NameToLayer("Green");
        BLUE = LayerMask.NameToLayer("Blue");

        mr = GetComponent<MeshRenderer>();
    }

    void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            int color = gameObject.layer;

            if (color == BLACK || color == YELLOW)
            {
                color = GREEN;
                mr.material = green;
            }
            else if (color == GREEN)
            {
                color = BLUE;
                mr.material = blue;
            }
            else if (color == BLUE)
            {
                color = YELLOW;
                mr.material = yellow;
            }

            gameObject.layer = color;
        }
	}
}
