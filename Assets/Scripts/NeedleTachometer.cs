using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleTachometer : MonoBehaviour
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
        float rpmRatio = (Mathf.Abs(ThisSpeed) / ThisTopSpeed);
        m_RectTransform = gameObject.GetComponent<RectTransform>();
        m_RectTransform.localRotation = Quaternion.Euler(0, 0, (rpmRatio*-200)+5);
    }
}
