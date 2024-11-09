using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class CapivaraScene : MonoBehaviour
{
    public Button back; 

    void Start()
    {
         back.onClick.AddListener(LoadBack);
    }

    public void LoadBack()
    {
        SceneManager.LoadScene("CapivaraGames");
    }
}

