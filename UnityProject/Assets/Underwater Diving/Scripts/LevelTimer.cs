using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour
{

    public float levelTime = 30f;
    public static float timeRemaining;
    public Text timerText;
    public GameObject gameOverScreen;


    void Start()
    {
        timeRemaining = levelTime;
    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;

        if (timerText != null)
        {
            timerText.text = "Tempo: " + Mathf.Ceil(timeRemaining).ToString();
        }

        if (timeRemaining <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        Debug.Log("O tempo acabou!");

        /*
        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(true);
        }
        */


        PlayerPrefs.SetInt("Pontuacao", 10); // valor qualquer por enquanto
        SceneManager.LoadScene("FinalScene");

        // Opcional: pause o jogo
        Time.timeScale = 0f;
    }
}
