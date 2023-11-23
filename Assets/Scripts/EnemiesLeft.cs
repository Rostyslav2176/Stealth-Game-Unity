using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EnemiesLeft : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    int kills;


    void Update()
    {
        ShowEnemies();
        if(kills >= 3)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void ShowEnemies()
    {
        counterText.text = kills.ToString();
    }

    public void RemoveEnemy()
    {
        kills++;
    }
}
