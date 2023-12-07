using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoundInteraction3 : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactaction;

    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactaction.Invoke();
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Agent3"))
        {
            isInRange = true;
        }
    }

    private void OntriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Agent3"))
        {
            isInRange = false;
        }
    }
}
