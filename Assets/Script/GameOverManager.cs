using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel;      
    public TextMeshProUGUI gameOverText;
    public Button retryButton;
    public Button quitButton;

    void Start()
    {
        gameOverPanel.SetActive(false);
        retryButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);

        retryButton.onClick.AddListener(RestartGame);
        quitButton.onClick.AddListener(QuitGame);
    }

    public void TriggerGameOver()
    {
        gameOverPanel.SetActive(true);       
        gameOverText.gameObject.SetActive(true);  

        Invoke("ShowButtons", 2f);
    }

    void ShowButtons()
    {
        retryButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }

    void RestartGame()
    {
        Time.timeScale = 1f; 
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
