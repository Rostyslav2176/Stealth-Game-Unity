using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtributesManager : MonoBehaviour
{
    public float health;
    public float attack;   

    public void TakeDamage(float amount)
    {
        health -= amount;
    }
     
    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AtributesManager>();
        if(atm != null)
        {
            atm.TakeDamage(attack);
        }
    }


}
