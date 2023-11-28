using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemykill3 : MonoBehaviour
{
    public Transform enemy;
    public bool inKillRange3 = false;
    public float detectionRange;
    EnemiesLeft enemiesLeft;


    void Start()
    {
        enemiesLeft = GameObject.Find("KCO").GetComponent<EnemiesLeft>();
    }

    public void Update()
    {
        EnemiesKill3();
    }
    void EnemiesKill3()
    {
        float distanceToEnemy = Vector3.Distance(transform.position, enemy.position);

        if (distanceToEnemy <= detectionRange)
        {
            inKillRange3 = true;

        }

        if (Input.GetKeyDown(KeyCode.E) && inKillRange3 == true)
        {
            GameObject.FindGameObjectWithTag("Agent3").SetActive(false);

            enemiesLeft.RemoveEnemy();
        }
    }
}
