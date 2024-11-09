using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HurtPlayer : MonoBehaviour
{

    private PlayerController thePlayer;
    public Text messageText;
    public static int pontuacao = 1000;

    // Use this for initialization
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();

        // Procura o objeto com a tag e pega o componente Text
        GameObject messageObject = GameObject.FindWithTag("MessageText");
        if (messageObject != null)
        {
            messageText = messageObject.GetComponent<Text>();
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {

       if (gameObject.tag == "LixoObjeto")
        {
            pontuacao -= 10;
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
        } else if (gameObject.tag == "LixoPerigoso")
        {
            pontuacao -= 35;
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
        } else if (gameObject.tag == "LixoEletronico")
        {
            pontuacao -= 20;
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
        } else if (gameObject.tag == "LixoAlimento")
        {
            pontuacao -= 5;
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
        } else if (gameObject.tag == "LixoRemedio")
        {
            pontuacao -= 30;
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
        } else if (gameObject.tag == "LixoBomba")
        {
            pontuacao += 50;
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
        }
    }
}
