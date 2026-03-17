using UnityEngine;

public class Movement2 : MonoBehaviour
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

        speed = Mathf.Clamp(speed, -10, maxSpeed);
    }


}

