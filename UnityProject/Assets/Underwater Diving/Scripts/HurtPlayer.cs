using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HurtPlayer : MonoBehaviour
{

    private PlayerController thePlayer;
    public Text messageText;
    public static int pontuacao = 500;

    void Start()
    {
        
        thePlayer = FindObjectOfType<PlayerController>();

        GameObject messageObject = GameObject.FindWithTag("MessageText");
        if (messageObject != null)
        {
            messageText = messageObject.GetComponent<Text>();
            messageText.text = "Nivel de Poluicao: " + pontuacao.ToString();
        }

    }

    void Update()
    {

        Debug.Log("Update");
        Scene currentScene = SceneManager.GetActiveScene();
        Debug.Log(currentScene);
        Debug.Log(currentScene.name);
        if (currentScene.name == "Level3" && pontuacao == 0)
        {
            SceneManager.LoadScene("FinalScene");
            Debug.Log("Trocando Cena");
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {


        if (gameObject.tag == "LixoObjeto")
        {
            pontuacao -= 10;
            messageText.text = "Nivel de Poluicao: " + pontuacao.ToString();
            Destroy(gameObject);
        } else if (gameObject.tag == "LixoPerigoso")
        {
            pontuacao -= 35;
            messageText.text = "Nivel de Poluicao: " + pontuacao.ToString();
            Destroy(gameObject);
        } else if (gameObject.tag == "LixoEletronico")
        {
            pontuacao -= 20;
            messageText.text = "Nivel de Poluicao: " + pontuacao.ToString();
            Destroy(gameObject);
        }
        else if (gameObject.tag == "LixoAlimento")
        {
            pontuacao -= 5;
            messageText.text = "Nivel de Poluicao: " + pontuacao.ToString();
            Destroy(gameObject);
        }
        else if (gameObject.tag == "LixoRemedio")
        {
            pontuacao -= 30;
            messageText.text = "Nivel de Poluicao: " + pontuacao.ToString();
            Destroy(gameObject);
        }
        else if (gameObject.tag == "LixoBomba")
        {
            pontuacao += 50;
            messageText.text = "Nivel de Poluicao: " + pontuacao.ToString();
            Destroy(gameObject);
        }
    }
}