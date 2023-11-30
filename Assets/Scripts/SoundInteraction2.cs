using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SoundInteraction2 : MonoBehaviour
{
    public bool isInRange;
    public UnityEvent interactaction;

    void Update()
    {
        if (isInRange)
        {
            interactaction.Invoke();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Agent2"))
        {
            isInRange = true;
        }
    }

    private void OntriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Agent2"))
        {
            isInRange = false;
        }
    }
}
