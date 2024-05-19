using UnityEngine;
using TMPro; // TextMeshPro s�n�f�n� kullanmak i�in

public class Timer : MonoBehaviour
{
    public float totalTime = 60f;
    private float timer;
    public TMP_Text timerText; // TMP_Text referans�

    private bool gameEnded = false;

    void Start()
    {
        timer = totalTime;
    }

    void Update()
    {
        if (!gameEnded)
        {
            timer -= Time.deltaTime;
            if (timerText != null)
            {
                timerText.text = "Kalan Zaman: " + Mathf.Ceil(timer).ToString();
            }

            if (timer <= 0)
            {
                EndGame();
            }
        }
    }

    void EndGame()
    {
        gameEnded = true;
        Debug.Log("Oyun Bitti!");
        if (timerText != null)
        {
            timerText.text = "Oyun Bitti !";
        }
    }
}
