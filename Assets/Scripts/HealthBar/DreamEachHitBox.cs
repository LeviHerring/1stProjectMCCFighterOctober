using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamEachHitBox : MonoBehaviour
{
    public float damage; 

    HealthBar healthBar;



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
        if (collision.gameObject.tag == "FruitBerries")
        {
            Debug.Log("Hit ON FRUIT Detected");
            healthBar.GetCoins(damage);

        }
        else if (collision.gameObject.tag == "PeteZahHutt")
        {
            Debug.Log("Hit ON PETE Detected");
            healthBar.GetCoins(damage);
        }

    }
}