using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpeedUI : MonoBehaviour
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
        int SpeedDisplay = (int)GameObject.Find("Player").GetComponent<Player>().SPEED;
        myText.text = SpeedDisplay.ToString() + " km/h";
    }
}
