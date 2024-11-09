using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class History : MonoBehaviour
{
    public Button back; 
    public Button rules;

    void Start()
    {
         back.onClick.AddListener(LoadBack);
         rules.onClick.AddListener(LoadRules);
    }

    public void LoadBack()
    {
        SceneManager.LoadScene("title-screen");
    }

    public void LoadRules()
    {
        SceneManager.LoadScene("Rules");
    }
}

