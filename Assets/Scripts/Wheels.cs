using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheels : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
            {
                transform.Rotate(50f, 0.0f, 0.0f);
            }
        if (Input.GetKeyUp("left"))
        {
            transform.Rotate(-50f , 0.0f, 0.0f );
        }
        if (Input.GetKeyDown("right"))
        {
            transform.Rotate(-50f, 0.0f, 0.0f);
        }
        if (Input.GetKeyUp("right"))
        {
            transform.Rotate(50f, 0.0f, 0.0f);
        }
    }
}
