using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressEnter : MonoBehaviour
{

    public SpriteRenderer mySprite;

    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        StartCoroutine("blinkText");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Level1");
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene("Creditos");
        }
    }

    public IEnumerator blinkText()
    {
        while (enabled)
        {
            mySprite.color = new Color(0f, 0f, 0f, 0f);
            yield return new WaitForSeconds(1f);
            mySprite.color = new Color(1f, 1f, 1f, 1f);
            yield return new WaitForSeconds(1f);
        }
    }
}

