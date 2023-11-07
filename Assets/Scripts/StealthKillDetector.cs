using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealthKillDetector : MonoBehaviour
{
    Guard guard;
    [SerializeField] bool canBeStealthKilled;

    void Start()
    {
        guard = transform.parent.GetComponent<guard>();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && guard.isAlive && canBeStealthKilled)
        {            
            guard.killButton.SetActive(false);
            guard.GetStealthKilled();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            guard.killButton.SetActive(true);
            canBeStealthKilled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            guard.killButton.SetActive(false);
        }
    }
}
