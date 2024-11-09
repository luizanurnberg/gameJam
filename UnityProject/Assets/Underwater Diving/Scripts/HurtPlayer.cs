using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HurtPlayer : MonoBehaviour
{

    private PlayerController thePlayer;
    public Text messageText;
    private static int pontuacao;

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
        if (other.tag == "Player")
        {
            thePlayer.hurt();
            pontuacao += 1;
            messageText.text = ("Pontuação: " + pontuacao.ToString());
        }

    }
}
