using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    private PlayerController thePlayer;
    public GameObject death;
    private Rigidbody2D myRigidbody;

    private UIManager uiManager;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        myRigidbody = GetComponent<Rigidbody2D>();

        uiManager = FindObjectOfType<UIManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Instantiate(death, transform.position, transform.rotation);
            LevelTimer.timeRemaining += 5;

            if (uiManager != null)
            {
                uiManager.ShowTimeAddedMessage(2f);
            }

            Destroy(gameObject);
        }
    }
}
