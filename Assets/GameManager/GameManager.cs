using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI player1Text;
    public TextMeshProUGUI player2Text;
    public TextMeshProUGUI timerText;

    int player1Score = 0;
    int player2Score = 0;

    public GameObject powerBallPrefab;

    float spawnTimer = 5f;
    float currentTime;

    void Start()
    {
        UpdateScore();
        currentTime = spawnTimer;
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        timerText.text = "Death Ball In: " + currentTime.ToString("F2");

        if(currentTime <= 0)
        {
            SpawnBall();
            currentTime = spawnTimer;
        }
    }

    void SpawnBall()
{
    Vector2 spawnPos = new Vector2(0f, 4f);  
    GameObject newBall = Instantiate(powerBallPrefab, spawnPos, Quaternion.identity);

    Rigidbody2D rb = newBall.GetComponent<Rigidbody2D>();
    if(rb != null)
    {
        float initialSpeed = 5f; 
        float direction = Random.value > 0.5f ? 1f : -1f;  // 50% chance left or right
        rb.velocity = new Vector2(direction * initialSpeed, 0f); // moves horizontally
    }
}

    public void Player1Wins()
    {
        player1Score++;
        UpdateScore();
    }

    public void Player2Wins()
    {
        player2Score++;
        UpdateScore();
    }

    void UpdateScore()
    {
        player1Text.text = "P1 Score: " + player1Score;
        player2Text.text = "P2 Score: " + player2Score;
    }

    public void ClearAllBalls()
{
    PowerBall[] balls = FindObjectsOfType<PowerBall>();
    foreach(PowerBall ball in balls)
    {
        Destroy(ball.gameObject);
    }
}
}
