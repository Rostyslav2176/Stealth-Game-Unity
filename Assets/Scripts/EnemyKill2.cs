using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemykill2 : MonoBehaviour
{
    public Transform enemy;
    public bool inKillRange2 = false;
    public float detectionRange;
    EnemiesLeft enemiesLeft;


    void Start()
    {
        enemiesLeft = GameObject.Find("KCO").GetComponent<EnemiesLeft>();
    }

    public void Update()
    {
        EnemiesKill2();
    }
    void EnemiesKill2()
    {
        float distanceToEnemy = Vector3.Distance(transform.position, enemy.position);

        if (distanceToEnemy <= detectionRange)
        {
            inKillRange2 = true;

        }

        if (Input.GetKeyDown(KeyCode.E) && inKillRange2 == true)
        {
            GameObject.FindGameObjectWithTag("Agent2").SetActive(false);

            enemiesLeft.RemoveEnemy();
        }
    }
}
