using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemiesLeft : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    int kills;


    void Update()
    {
        ShowEnemies();
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
