using UnityEngine;

public class PowerBall : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 8f;
    public float speedIncrease = 0.5f;
    public float maxSpeed = 20f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Vector2 randomDirection = new Vector2(Random.Range(-1f,1f), Random.Range(-1f,1f)).normalized;

        rb.velocity = randomDirection * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        speed += speedIncrease;

        if(speed > maxSpeed)
        {
            speed = maxSpeed;
        }

        rb.velocity = rb.velocity.normalized * speed;
    }
}
