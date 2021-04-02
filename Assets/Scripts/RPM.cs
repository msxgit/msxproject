using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RPM : MonoBehaviour
{
    Text myText;

    float MAX_RPM = 5500;
    float IDLE_RPM = 900;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        myText = gameObject.GetComponent<Text>();
        float ThisSpeed = GameObject.Find("Player").GetComponent<Player>().SPEED;
        float ThisTopSpeed = GameObject.Find("Player").GetComponent<Player>().TOP_SPEED;
        float Display = Mathf.Abs(((MAX_RPM-IDLE_RPM) * (Mathf.Abs(ThisSpeed) / ThisTopSpeed))+IDLE_RPM);
        int kurwa = (int)Display;

        myText.text = kurwa.ToString() + " RPM";
    }
}
