using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemykill : MonoBehaviour
{
    public Transform enemy;
    public bool inKillRange = false;
    public float detectionRange;
    EnemiesLeft enemiesLeft;


    void Start()
    {
        enemiesLeft = GameObject.Find("KCO").GetComponent<EnemiesLeft>();
    }

    public void Update()
    {
        EnemiesKill();
    }
    void EnemiesKill()
    {
        float distanceToEnemy = Vector3.Distance(transform.position, enemy.position);

        if (distanceToEnemy <= detectionRange)
        {
            inKillRange = true;

        }

        if (Input.GetKeyDown(KeyCode.E) && inKillRange == true)
        {
            GameObject.FindGameObjectWithTag("Agent").SetActive(false);

            enemiesLeft.RemoveEnemy();
        }
    }
}
