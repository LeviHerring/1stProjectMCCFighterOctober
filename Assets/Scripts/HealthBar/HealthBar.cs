using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class HealthBar : MonoBehaviour
{

    public Image healthBar;

    public float health;


    // Start is called before the first frame update


    
    void Start()
    {

        healthBar.fillAmount = health;
        health = 0f;
    }

    public void GetCoins(float amount)
    {
        health += amount;
        healthBar.fillAmount = health;
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
