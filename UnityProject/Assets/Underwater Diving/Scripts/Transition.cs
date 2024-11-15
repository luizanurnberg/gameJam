﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneName;
    public GameObject bubbleEffectPrefab;
    public AudioClip bubbleSound;
    private AudioSource audioSource;

    private UIManager uiManager;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;

        uiManager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && HurtPlayer.pontuacao == 0)
        {
            StartCoroutine(TransitionWithBubbleEffect());
        } else
        {
            if (uiManager != null)
            {
                uiManager.ShowGenericMessage(2f, "Voce precisa recolher todo o lixo!");
            }
        }
    }

    private IEnumerator TransitionWithBubbleEffect()
 {
     GameObject bubbleEffect = Instantiate(bubbleEffectPrefab, transform.position, Quaternion.identity);

     if (bubbleSound != null)
     {
         audioSource.clip = bubbleSound;
         audioSource.Play();
     }

     yield return new WaitForSeconds(3);

     Destroy(bubbleEffect);

     SceneManager.LoadScene(sceneName);

     Debug.Log("SceneName: " + sceneName);
     if (sceneName == "EffectBubbleLevel2")
     {
         HurtPlayer.pontuacao = 350;
         Debug.Log("Definiu nova pontuação 2");
     }
     
     
     if (sceneName == "EffectBubbleLevel3") 
     {
         HurtPlayer.pontuacao = 150;
         Debug.Log("Definiu nova pontuação 3");
     }
 }
}
