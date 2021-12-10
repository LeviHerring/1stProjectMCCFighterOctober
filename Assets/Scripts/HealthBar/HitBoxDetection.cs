using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using System;

public class HitBoxDetection : MonoBehaviour
{


    HealthBar healthBar;
    
 

    [SerializeField]
    GameObject ownHtibox; 
    // Start is called before the first frame update
    void Start()
    {
        GameObject dream = GameObject.Find("DREAM"); //null for some reason??
        healthBar = dream.GetComponent<HealthBar>(); //null for some reason?? 

        


    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == ownHtibox)
        {
            healthBar.GetCoins(0f);
        }
        if (collision.gameObject.name == "FruitBerriesTemplate_0")
        {
            Debug.Log("Hit ON FRUIT Detected");
            healthBar.GetCoins(0.0000000000000000001f);
            
        }
        else if (collision.gameObject.name == "PeteZahHuttTemplate_0")
        {
            Debug.Log("Hit ON PETE Detected");
            healthBar.GetCoins(0.0000000000000000000001f);
        }
        else if (collision.gameObject.name == "DREAM")
        {
            Debug.Log("HIT ON DREAM AAAAAAAAAA"); 
            healthBar.GetCoins(1f); 
        }
    }
}
