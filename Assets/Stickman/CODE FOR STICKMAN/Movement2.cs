using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0;


    public float maxSpeed = 10;

    [Header("Shield Settings")]
    public GameObject shield;        
    public KeyCode shieldKey;   


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(shield != null)
    shield.SetActive(Input.GetKey(shieldKey));

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            speed--;
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y,
                transform.position.z);

        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            speed = 0;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            speed++;
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y,
                transform.position.z);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            speed = 0;
        }

        speed = Mathf.Clamp(speed, -10, maxSpeed);
    }
}
