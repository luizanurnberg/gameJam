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
        // Recuperar a pontuação armazenada
        pontuacao = HurtPlayer.pontuacao;

        if (pontuacao == 0)
        {
            finalSceneTitulo.text = "VOCE GANHOU!";
        }
        else
        {
            finalSceneTitulo.text = "VOCE PERDEU!";
        }

        finalScenePontuacao.text = "Nivel de Poluição: " + pontuacao;
    }
}