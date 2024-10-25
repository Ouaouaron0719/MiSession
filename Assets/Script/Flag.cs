using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    public GameOverManager gameOverManager;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Nice");
            GameOver(); 
        }
    }
    void GameOver()
    {
        gameOverManager.TriggerGameOver();
    }
}
