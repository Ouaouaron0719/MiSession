using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 100;     
    public int currentHealth;       
    public TextMeshProUGUI healthText;  

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
    }

    void UpdateHealthUI()
    {
        healthText.text = "PV: " + currentHealth;
    }
}
