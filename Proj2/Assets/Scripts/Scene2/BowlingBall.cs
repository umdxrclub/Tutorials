using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : MonoBehaviour
{
    // This function runs once, at the beginning of the simulation.
    void Start()
    {
        /* Components can be accessed from any script by using GetComponent<T>(), where T is the name of the component type.
         * Make sure that the script is on the same object as the component you are trying to access.
         * 
         * We're going to play with the rigidbody component.
         * Compare the variables in the code below with the variables in the inspector (mass, drag, angular drag, etc.).
         * 
         * Run the project and compare the values printed in the console with the inspector values.
         */

        // Note: Debug.Log is how we print things to the console.

        Debug.Log("Mass: " + GetComponent<Rigidbody>().mass);
        Debug.Log("Drag: " + GetComponent<Rigidbody>().drag);
        Debug.Log("Angular Drag: " + GetComponent<Rigidbody>().angularDrag);
        Debug.Log("Use Gravity: " + GetComponent<Rigidbody>().useGravity);
        Debug.Log("Is Kinematic: " + GetComponent<Rigidbody>().isKinematic);
        Debug.Log("Interpolate: " + GetComponent<Rigidbody>().interpolation);
        Debug.Log("Collision Detection: " + GetComponent<Rigidbody>().collisionDetectionMode);

        /* You might have noticed that this ball rolls very slowly. This is because its maximum angular velocity is pretty low (7 I think)
         * If you look at the inspector, there is no option to set the maximum angular velocity. This must be set within the code.
         * 
         * Get the rigidbody component, access the rigidbody's maximum angular velocity (named maxAngularVelocity), and set it to 100.
         * 
         * You can also play with the mass to make the bowling ball look more realistic.
         */

        GetComponent<Rigidbody>().maxAngularVelocity = 100;
    }
}
