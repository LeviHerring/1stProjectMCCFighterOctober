using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelectScreen : MonoBehaviour
{


    [SerializeField]
    public int position = 0; 

    [SerializeField]
    public int[] bounds;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKey(KeyCode.S))
            {
                if (!(position <= bounds[0]))
                {
                    position = position - 1;
                    transform.position += new Vector3(-3, 0, 0);
                }
            }
        if (Input.GetKey(KeyCode.D))
        {
            if (!(position >= bounds[1]))
            {
                position = position + 1;
                transform.position += new Vector3(3, 0, 0);
            }
        }


    }
}
