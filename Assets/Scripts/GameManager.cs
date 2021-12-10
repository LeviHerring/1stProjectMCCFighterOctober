using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject dream;
    [SerializeField] GameObject fruitBerries;
    [SerializeField] GameObject peteZahHutt;
    [SerializeField] Transform playerOnePos;
    [SerializeField] Transform playerTwoPos; 


    // Start is called before the first frame update
    void Start()
    {
        string playerOne = PlayerPrefs.GetString("Player1");
        string playerTwo = PlayerPrefs.GetString("Player2");

        switch (playerOne)
        {
            case "Dream":
                dream.SetActive(true);
                dream.transform.position = playerOnePos.position;
                break;

            case "FruitBerries":
                fruitBerries.SetActive(true);
                fruitBerries.transform.position = playerOnePos.position;
                break;

            case "PeteZahHutt":
                peteZahHutt.SetActive(true);
                peteZahHutt.transform.position = playerOnePos.position;
                break; 
        }

        switch (playerTwo)
        {
            case "Dream":
                dream.SetActive(true);
                dream.transform.position = playerTwoPos.position;
                break;

            case "FruitBerries":
                fruitBerries.SetActive(true);
                dream.transform.position = playerTwoPos.position;
                break;

            case "PeteZahHutt":
                peteZahHutt.SetActive(true);
                peteZahHutt.transform.position = playerTwoPos.position;
                break; 
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
