using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class HealthBar : MonoBehaviour
{
    public bool isPlayerOne; 
    public PlayerController playerController; 
    public GameObject healthBarPlayer2Object;
    public Image healthBarPlayer2;

    public GameObject healthBarObject;
    public Image healthBar;

    public float health;
    public float healthPlayer2; 


    // Start is called before the first frame update


    
    void Start()
    {
        if(playerController.isPlayerOne == true)
        {
            healthBarObject.SetActive(true);
            healthBarPlayer2Object.SetActive(false);
        }
        else
        {
            healthBarPlayer2Object.SetActive(true);
            healthBarObject.SetActive(false);
        }
        healthBar.fillAmount = health;
        health = 0f;
    }

    public void GetCoins(float amount)
    {
        health += amount;
        if (healthBarObject.activeSelf == true)
        {
            healthBar.fillAmount = health;
        }
        else
        {
            healthBarPlayer2.fillAmount = health; 
        }

    }    

    // Update is called once per frame
    void Update()
    {
        if(health >= 1)
        {
            SceneManager.LoadScene("GameOver");
        }
        
    }


}
