using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // Nome da cena para a qual o player será transportado
    public string sceneName;

    // Detecta a colisão com o player
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Verifica se o objeto é o player
        {
            SceneManager.LoadScene(sceneName); // Carrega a nova cena
        }
    }
}
