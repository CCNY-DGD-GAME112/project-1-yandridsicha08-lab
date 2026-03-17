using UnityEngine;

public class BallHitPlayer : MonoBehaviour
{
    public GameManager gameManager;

    private void Awake()
    {
        // Automatically find the GameManager in the scene
        if (gameManager == null)
            gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject other = collision.gameObject;

        if (other.CompareTag("Player"))
        {
            
            PlayerShieldStatus shieldStatus = other.GetComponent<PlayerShieldStatus>();
            if (shieldStatus != null && shieldStatus.isShieldActive)
            {
                
                return;
            }

            
            if (other.name == "stickman")
                gameManager.Player2Wins();
            else if (other.name == "stickman2")
                gameManager.Player1Wins();

            // Remove all balls
            gameManager.ClearAllBalls();

            // Respawn player at defined positions
            if (other.name == "stickman")
                other.transform.position = new Vector3(-5.5f, 3.4f, 0f);
            else
                other.transform.position = new Vector3(4.5f, 3.4f, 0f);
        }
    }
}
