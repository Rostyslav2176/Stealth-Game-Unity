using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemykill : MonoBehaviour
{
    EnemiesLeft killCounter;
   public void Kill()
    {
        killCounter = GameObject.Find("KCO").GetComponent<EnemiesLeft>();
        killCounter.RemoveEnemy();
        Destroy(GameObject.FindWithTag("Agent"));
    }
}
