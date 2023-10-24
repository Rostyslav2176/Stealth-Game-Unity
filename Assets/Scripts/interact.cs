using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour, IInteractable
{
    Renderer ren;
  public void Interact()
    {
        ren = GetComponent<Renderer>();
        ren.material.color = Color.red;
    }
}
