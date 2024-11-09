using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class CapivaraGames : MonoBehaviour
{
    public Button back; 

    void Start()
    {
         back.onClick.AddListener(LoadBack);
    }

    public void LoadBack()
    {
        SceneManager.LoadScene("title-screen");
    }
}

