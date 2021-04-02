using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GearUI : MonoBehaviour
{
    Text myText;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        myText = gameObject.GetComponent<Text>();
        int GearDisplay = GameObject.Find("Player").GetComponent<Player>().GEAR;
        if(GearDisplay!=0)
            myText.text = GearDisplay.ToString();
        else
            myText.text = "R";
    }
}
