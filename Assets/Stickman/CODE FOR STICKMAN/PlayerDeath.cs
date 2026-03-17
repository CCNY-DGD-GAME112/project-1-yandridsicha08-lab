using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameManager gameManager;
    public int playerNumber;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("DeathZone"))
        {
            if(playerNumber == 1)
            {
                gameManager.Player2Wins();
            }
            else
            {
                gameManager.Player1Wins();
            }

            transform.position = Vector3.zero;
        }
    }
}
