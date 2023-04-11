using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class PlayerHealth : MonoBehaviour
{
    public Image healthbar;
    public float playerHealth;
    public float currentHealth;
    public PlayerController player;
    public CinemachineVirtualCamera cam;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = playerHealth;
    }

    // Update is called once per frame
    public void takeDamage(float damage)
    {
        
        currentHealth -= damage;
        healthbar.fillAmount = currentHealth / playerHealth;
        if(currentHealth <= 0 )
        {
            cam.enabled = false;
            player.gameOver = true;
            player.playerDead();
        }
    }
}
