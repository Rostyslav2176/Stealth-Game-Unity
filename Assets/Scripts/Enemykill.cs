using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemykill : MonoBehaviour
{
    public Transform enemy;
    public bool inKillRange = false;
    public float detectionRange;

    public void Update()
    {
        float distanceToEnemy = Vector3.Distance(transform.position, enemy.position);

        if(distanceToEnemy <= detectionRange)
        {
            inKillRange = true;
        }

        if(Input.GetKeyDown(KeyCode.E) && inKillRange == true)
        {
            Destroy(GameObject.FindGameObjectWithTag("Agent"));
        }
    }
}
