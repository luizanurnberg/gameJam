using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text timeAddedText;
    private float displayTime;
    private float timer;

    void Start()
    {
        if (timeAddedText != null)
        {
            timeAddedText.text = "";
        }
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            if (timer <= 0 && timeAddedText != null)
            {
                timeAddedText.text = "";
            }
        }
    }

    public void ShowTimeAddedMessage(float duration)
    {
        if (timeAddedText != null)
        {
            timeAddedText.text = "5 segundos adicionados!";
            timer = duration;
        }
    }

    public void ShowTimeRemovedMessage(float duration)
    {
        if (timeAddedText != null)
        {
            timeAddedText.text = "Voce perdeu 5 segundos! Cuidado com a vida marinha!";
            timer = duration;
        }
    }

    public void ShowGenericMessage(float duration, string message)
    {
        if (timeAddedText != null)
        {
            timeAddedText.text = message;
            timer = duration;
        }
    }
}
