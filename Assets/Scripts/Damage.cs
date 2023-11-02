using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public AtributesManager playerAtm;
    public AtributesManager enemyAtm;
    
    
    void OnCollisionEnter(Collision playerAtm)
    {
        enemyAtm.DealDamage(playerAtm.gameObject);
    }
}
