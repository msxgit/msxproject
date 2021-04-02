using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    //int CameraSetting = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            transform.localPosition = new Vector3(0, 3.5f, 2f);
            transform.Rotate(50f, 180f, 0.0f);
        }
        
        if (Input.GetKeyUp("q"))
        {
            transform.localPosition = new Vector3(0, 3.5f, -2f);
            transform.Rotate(50f, 180f, 0.0f);
        }
    }
}
