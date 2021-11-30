using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class HealthBar : MonoBehaviour
{

    public Image healthBar;

    private float health;


    [SerializeField]
    GameObject ownHtibox; 
    // Start is called before the first frame update


    
    void Start()
    {
        health = 0f;
        healthBar.fillAmount = health; 
    }

    void GetCoins(float amount)
    {
        health += amount;
        healthBar.fillAmount = health;
    }    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == ownHtibox)
        {
            GetCoins(0f); 
        }
        else
        {
            if(collision.gameObject.tag == "Player")
            {
                GetCoins(0.001f); 
            }

        }
    }
}
