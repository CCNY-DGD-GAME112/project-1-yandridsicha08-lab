using UnityEngine;

public class PlayerShieldStatus : MonoBehaviour
{
    public GameObject shield;   
    [HideInInspector] public bool isShieldActive;

    void Update()
    {
        if(shield != null)
            isShieldActive = shield.activeSelf;
    }
}
