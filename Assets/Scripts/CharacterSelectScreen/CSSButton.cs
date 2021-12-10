using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CSSButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Character()
    {
        switch (GameObject.Find("CharacterSelectGreen").GetComponent<CharacterSelectScreen>().position)
        {
            case 0:
                PlayerPrefs.SetString("Player1", "Dream");
                break;
            case 1:
                PlayerPrefs.SetString("Player1", "FruitBerries");
                break;
            case 2:
                PlayerPrefs.SetString("Player1", "PeteZahHutt");
                break; 
        }

        switch (GameObject.Find("CharacterSelectPink").GetComponent<Player2CSS>().position)
        {
            case 0:
                PlayerPrefs.SetString("Player2", "Dream");
                break;
            case 1:
                PlayerPrefs.SetString("Player2", "FruitBerries");
                break;
            case 2:
                PlayerPrefs.SetString("Player2", "PeteZahHutt");
                break; 
        }
        SceneManager.LoadScene("FightingScene"); 
    }    
}
