using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class PressEnter2 : MonoBehaviour
{
    public Button history; 

    void Start()
    {
         history.onClick.AddListener(LoadHistory);
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

    public void LoadHistory()
    {
        SceneManager.LoadScene("History");
    }
}

