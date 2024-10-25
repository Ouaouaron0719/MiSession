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
    public GameObject gameOverText;

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

    void UpdateHealthUI()
    {
        healthText.text = "PV: " + currentHealth;
    }

    void GameOver()
    {
        gameOverText.SetActive(true);
        Time.timeScale = 0f;
    }
}
