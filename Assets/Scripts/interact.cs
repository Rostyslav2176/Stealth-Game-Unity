using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour, IInteractable
{
    Renderer ren;
    public Renderer render;
    public float cooldown;
    float activeTime;

    public void Interact()
    {
        ren = GetComponent<Renderer>();
        ren.material.color = Color.red;

    }

  
    public void Update()
    {
        if (Time.time - activeTime < cooldown)
        {
            render.material.color = Color.green;            
            return;
        }
        activeTime = Time.time;
    }
   
}
