using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionBubble : MonoBehaviour
{
    public string sceneName;
    public GameObject bubbleEffectPrefab;
    public AudioClip bubbleSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;

        StartCoroutine(TransitionWithDelay());
    }

    private IEnumerator TransitionWithDelay()
    {
        GameObject bubbleEffect = Instantiate(bubbleEffectPrefab, transform.position, Quaternion.identity);

        if (bubbleSound != null)
        {
            audioSource.clip = bubbleSound;
            audioSource.Play();
        }

        yield return new WaitForSeconds(5);

        Destroy(bubbleEffect);
        SceneManager.LoadScene(sceneName);
    }
}
