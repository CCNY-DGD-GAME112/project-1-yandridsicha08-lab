using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0;

    public float jumpSpeed = 0;

    public float maxSpeed = 10;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            speed--;
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y,
                transform.position.z);

        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            speed = 0;
        }

        if (Input.GetKey(KeyCode.D))
        {
            speed++;
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y,
                transform.position.z);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            speed = 0;
        }

        bool isGrounded = transform.position.y <= 1.5f;

        if (Input.GetKey(KeyCode.W) && isGrounded)
        {
            jumpSpeed = 100;
            transform.position = new Vector3(transform.position.x, transform.position.y + jumpSpeed * Time.deltaTime,
                transform.position.z);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            jumpSpeed = 0;
        }

        speed = Mathf.Clamp(speed, -10, maxSpeed);

        jumpSpeed = Mathf.Clamp(jumpSpeed, -10, 100);
    }


}

