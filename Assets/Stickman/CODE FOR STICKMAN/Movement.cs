using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0;

    public float maxSpeed = 10;
    
    public bool reachedMaxSpeed = false;
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

            if (Input.GetKey(KeyCode.W))
            {
                speed++;
                transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime,
                    transform.position.z);
            }

            speed = Mathf.Clamp(speed, -10, maxSpeed);
        }

        
    }

