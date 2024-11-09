using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Adicionar para usar UI

public class FinalSceneScript : MonoBehaviour
{
    public int pontuacao;

    // Referências aos objetos de texto
    public Text finalSceneTitulo;
    public Text finalScenePontuacao;

    private void Start()
    {


        //na tela que chamar esse script, chamar assim:
        // PlayerPrefs.SetInt("Pontuacao", pontuacao);
        // SceneManager.LoadScene("FinalScene");


        pontuacao = PlayerPrefs.GetInt("Pontuacao", 0);

        if (pontuacao > 10)
        {
            finalSceneTitulo.text = "VOCE GANHOU!";
        }
        else
        {
            finalSceneTitulo.text = "VOCE PERDEU!";
        }

        finalScenePontuacao.text = "Pontuacao: " + pontuacao;
    }
}