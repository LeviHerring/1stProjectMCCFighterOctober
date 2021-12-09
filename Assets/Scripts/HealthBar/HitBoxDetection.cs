using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBoxDetection : MonoBehaviour
{


    HealthBar healthbar; 

    [SerializeField]
    GameObject ownHtibox; 
    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<HealthBar>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == ownHtibox)
        {
            GetComponent<HealthBar>().GetCoins(0f);
        }
        if (collision.gameObject.name == "FruitBerriesTemplate_0")
        {
            GetComponent<HealthBar>().GetCoins(0.001f);
            Debug.Log("Hit Detected");
        }

    }
}
