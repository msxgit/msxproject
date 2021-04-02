using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tachometer : MonoBehaviour
{
    RectTransform m_RectTransform;
    Image Target_Image;
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
        Target_Image = GameObject.Find("RedLine").GetComponent<Image>();
        m_RectTransform = gameObject.GetComponent<RectTransform>();
        m_RectTransform.localScale = new Vector3(rpmRatio + 0.2f, 0.2f, 0);
        if (rpmRatio <= 0.80f)
            Target_Image.color = new Color(1, 0, 0, 0);
        else if (rpmRatio <= 1.02f && rpmRatio > 0.80f)
            Target_Image.color =  new Color(1, 0, 0, rpmRatio * rpmRatio * rpmRatio * rpmRatio * rpmRatio);
        else
            Target_Image.color = new Color(1, 1, 0, rpmRatio);
    }
}
