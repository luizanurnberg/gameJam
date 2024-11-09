using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class HurtPlayer : MonoBehaviour
{

    private PlayerController thePlayer;
    public Text messageText;
    public static int pontuacao = 1000;

    public AudioClip somObjeto;
    private AudioSource audioSrc;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();

        // Procura o objeto com a tag e pega o componente Text
        GameObject messageObject = GameObject.FindWithTag("MessageText");
        if (messageObject != null)
        {
            messageText = messageObject.GetComponent<Text>();
        }

        audioSrc = GetComponent<AudioSource>();
        audioSrc.clip = somObjeto;
        audioSrc.Play();
    }


    void OnTriggerEnter2D(Collider2D other)
    {


        if (gameObject.tag == "LixoObjeto")
        {
            pontuacao -= 10;
            audioSrc.clip = somObjeto;
            audioSrc.time = 1;
            audioSrc.Play();
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
            Destroy(gameObject, audioSrc.clip.length);
        } else if (gameObject.tag == "LixoPerigoso")
        {
            pontuacao -= 35;
            audioSrc.clip = somObjeto;
            audioSrc.time = 1;
            audioSrc.Play();
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
            Destroy(gameObject, audioSrc.clip.length);
        } else if (gameObject.tag == "LixoEletronico")
        {
            pontuacao -= 20;
            audioSrc.clip = somObjeto;
            audioSrc.time = 1;
            audioSrc.Play();
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
            Destroy(gameObject, audioSrc.clip.length);
        }
        else if (gameObject.tag == "LixoAlimento")
        {
            pontuacao -= 5;
            audioSrc.clip = somObjeto;
            audioSrc.time = 1;
            audioSrc.Play();
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
            Destroy(gameObject, audioSrc.clip.length);
        }
        else if (gameObject.tag == "LixoRemedio")
        {
            pontuacao -= 30;
            audioSrc.clip = somObjeto;
            audioSrc.time = 1;
            audioSrc.Play();
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
            Destroy(gameObject, audioSrc.clip.length);
        }
        else if (gameObject.tag == "LixoBomba")
        {
            pontuacao += 50;
            audioSrc.clip = somObjeto;
            audioSrc.time = 1;
            audioSrc.Play();
            messageText.text = "Nivel de Poluição: " + pontuacao.ToString();
            Destroy(gameObject, audioSrc.clip.length);
        }
    }
}
