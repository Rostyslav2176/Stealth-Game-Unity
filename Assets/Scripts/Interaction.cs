using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IInteractable
{
    public void Interact();
    public void SoundP();
}

public class Interaction : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if(Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if(hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();
                    interactObj.SoundP();
                    Debug.Log("working");
                }
            }
        }
    }
}
