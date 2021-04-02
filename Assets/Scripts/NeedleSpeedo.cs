using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleSpeedo : MonoBehaviour
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
        float ThisMaxTopSpeed = GameObject.Find("Player").GetComponent<Player>().HIGHEST_TOP_SPEED;
        m_RectTransform = gameObject.GetComponent<RectTransform>();
        m_RectTransform.localRotation = Quaternion.Euler(0, 0, ((Mathf.Abs(ThisSpeed)/ThisMaxTopSpeed) * -190) + 15);
    }
}
