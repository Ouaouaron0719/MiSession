using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 100;     
    public int currentHealth;       
    public TextMeshProUGUI healthText;
    public GameOverManager gameOverManager;

    void Start()
    {
        currentHealth = maxHealth;     
        UpdateHealthUI();              
        //Unity Documentation
        InvokeRepeating("DecreaseHealth", 1f, 1f);
    }

    void DecreaseHealth()
    {
        if (currentHealth > 0)
        {
            currentHealth--;        
            UpdateHealthUI();         
        }

        if (currentHealth <= 0)
        {
            GameOver();             
        }
    }

    public void UpdateHealthUI()
    {
        healthText.text = "PV: " + currentHealth;
    }

    void GameOver()
    {
        gameOverManager.TriggerGameOver();
    }
}
