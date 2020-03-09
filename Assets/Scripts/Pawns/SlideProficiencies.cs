using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideProficiencies : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void changeSprite()
    {
        if (anim.GetBool("isOpen") == true)
        {
            anim.SetBool("isOpen", false);
        }
        else
        {
            anim.SetBool("isOpen", true);
        }
    }
}
