using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    public Animator actor;

    /* This class has all the code necessary to run the movie. You don't need to modify any of this code.
     * Instead, you will need to configure the remote to call the functions inside this class.
     * 
     * Remember, a MonoBehavior (and thus this class) is just a custom component.
     */

    public void ResetMovie()
    {
        actor.SetTrigger("ResetDancing");
    }

    public void PauseMovie()
    {
        actor.speed = 0;
    }

    public void PlayMovie()
    {
        actor.speed = 1;
    }

    public void LoopMovie()
    {
        actor.SetBool("Looping", !actor.GetBool("Looping"));
    }
}
