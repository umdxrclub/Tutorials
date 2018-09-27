using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    bool pressed;
    bool pressedDown;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider == GetComponent<MeshCollider>())
                {
                    pressed = true;
                    pressedDown = true;
                    transform.Translate(0, -0.001f, 0);
                }
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            if (pressed)
            {
                pressed = false;
                pressedDown = false;
                transform.Translate(0, 0.001f, 0);
            }
        }
    }

    public bool isPressedDown()
    {
        if (pressedDown) // Consume pressed down on first function call
        {
            pressedDown = false;
            return true;
        }
        return false;
    }
}
