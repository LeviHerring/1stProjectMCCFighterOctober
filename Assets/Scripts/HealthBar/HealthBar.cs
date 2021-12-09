using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthBar : MonoBehaviour
{

    public Image healthBar;

    private float health;


    // Start is called before the first frame update


    
    void Start()
    {

        healthBar = GetComponent<Image>(); 
        health = 0f;
        healthBar.fillAmount = health; 
    }

    public void GetCoins(float amount)
    {
        health += amount;
        healthBar.fillAmount = health;
    }    

    // Update is called once per frame
    void Update()
    {
        
    }


}