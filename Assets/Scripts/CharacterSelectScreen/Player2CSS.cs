using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2CSS : MonoBehaviour
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

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (!(position <= bounds[0]))
            {
                position--;
                transform.position += new Vector3(-6, 0, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (!(position >= bounds[1]))
            {
                position++;
                transform.position += new Vector3(6, 0, 0);
            }
        }


    }
}