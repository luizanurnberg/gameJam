using UnityEngine;
using UnityEngine.UI;

public class LightBorder : MonoBehaviour
{
    public Image imageToBlink;  // Refer�ncia para o componente Image
    public float blinkSpeed = 1.0f;  // Velocidade de piscar (quanto maior, mais r�pido)
    public float blinkDuration = 0.5f;  // Tempo que a imagem ficar� vis�vel ou invis�vel

    private bool isBlinking = false;

    void Start()
    {
        // Se n�o houver Image referenciada, tenta pegar automaticamente do pr�prio objeto
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

    // M�todo para iniciar o piscar
    public void StartBlinking()
    {
        isBlinking = true;
    }

    // M�todo para parar o piscar
    public void StopBlinking()
    {
        isBlinking = false;
        imageToBlink.color = new Color(imageToBlink.color.r, imageToBlink.color.g, imageToBlink.color.b, 1); // Garantir que fique vis�vel ao parar
    }
}
