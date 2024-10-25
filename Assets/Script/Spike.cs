using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField]public float fallSpeed = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            HealthManager healthManager = FindObjectOfType<HealthManager>();

            if (healthManager != null)
            {
                healthManager.currentHealth = Mathf.Max(healthManager.currentHealth - 20, 0);
                healthManager.UpdateHealthUI();
            }

            Destroy(gameObject);
        }

        else if (other.CompareTag("Floor"))
        {
            Destroy(gameObject);
        }
    }
}
