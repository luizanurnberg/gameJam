using UnityEngine;
using UnityEngine.UI;

public class LightBorder : MonoBehaviour
{
    public Image imageToBlink;  // Referência para o componente Image
    public float blinkSpeed = 1.0f;  // Velocidade de piscar (quanto maior, mais rápido)
    public float blinkDuration = 0.5f;  // Tempo que a imagem ficará visível ou invisível

    private bool isBlinking = false;

    void Start()
    {
        // Se não houver Image referenciada, tenta pegar automaticamente do próprio objeto
        if (imageToBlink == null)
        {
            imageToBlink = GetComponent<Image>();
        }
    }

    void Update()
    {
        // Inicia ou continua o efeito de piscar
        if (isBlinking)
        {
            float lerpValue = Mathf.PingPong(Time.time * blinkSpeed, blinkDuration) / blinkDuration;
            imageToBlink.color = new Color(imageToBlink.color.r, imageToBlink.color.g, imageToBlink.color.b, lerpValue);
        }
    }

    // Método para iniciar o piscar
    public void StartBlinking()
    {
        isBlinking = true;
    }

    // Método para parar o piscar
    public void StopBlinking()
    {
        isBlinking = false;
        imageToBlink.color = new Color(imageToBlink.color.r, imageToBlink.color.g, imageToBlink.color.b, 1); // Garantir que fique visível ao parar
    }
}
