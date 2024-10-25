using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melon : MonoBehaviour
{
    public int healthRecovery = 20;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Crashing");
            HealthManager healthManager = FindObjectOfType<HealthManager>();

            if (healthManager != null)
            {
                healthManager.currentHealth = Mathf.Min//Unity Documentation
                    (
                        healthManager.currentHealth + healthRecovery,
                        healthManager.maxHealth
                    );
                Destroy(gameObject);
            }
        }   
    }
}
