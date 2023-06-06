using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    Animator antimnatror;

    Jump mujpump;

    // Start is called before the first frame update
    void Start()
    {
        antimnatror = GetComponent<Animator>();
        mujpump = GetComponent<Jump>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!mujpump.cacanMujpump)
        {
            antimnatror.SetBool("isJumping", true);
            antimnatror.SetBool("isIdle", false);
            antimnatror.SetBool("isWalking", false);
            antimnatror.SetBool("isWalkingBackwards", false);
        }

        if(mujpump.cacanMujpump)
        {
            antimnatror.SetBool("isJumping", false);
            antimnatror.SetBool("isIdle", true);
            antimnatror.SetBool("isWalking", false);
            antimnatror.SetBool("isWalkingBackwards", false);

            if(Input.GetAxisRaw("Vertical") == 1)
            {
                antimnatror.SetBool("isIdle", false);
                antimnatror.SetBool("isWalking", true);
                antimnatror.SetBool("isWalkingBackwards", false);
            }

            if(Input.GetAxisRaw("Vertical") == -1)
            {
                antimnatror.SetBool("isIdle", false);
                antimnatror.SetBool("isWalking", false);
                antimnatror.SetBool("isWalkingBackwards", true);
            }
        }
    }
}
