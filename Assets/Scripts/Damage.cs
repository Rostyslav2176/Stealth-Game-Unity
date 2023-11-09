using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public AtributesManager playerAtm;
    public AtributesManager enemyAtm;

	void OnCollisionEnter(Collision playerAtm)
	{
		enemyAtm.DealDamage(playerAtm.gameObject);
		Debug.Log("Game Over");
		Restart();
	}	

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
