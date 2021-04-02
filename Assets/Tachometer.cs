using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tachometer : MonoBehaviour
{
    RectTransform m_RectTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ThisSpeed = GameObject.Find("Player").GetComponent<Player>().SPEED;
        float ThisTopSpeed = GameObject.Find("Player").GetComponent<Player>().TOP_SPEED;
        m_RectTransform = gameObject.GetComponent<RectTransform>();
        m_RectTransform.localScale = new Vector3((ThisSpeed / ThisTopSpeed) + 0.2f, 0.2f, 0);
    }
}
