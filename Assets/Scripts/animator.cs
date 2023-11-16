using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKey("w"))
        {
            anim.SetBool("isWalking", true);
        }

        if (!Input.GetKey("w"))
        {
            anim.SetBool("isWalking", false);
        }
    }
}
