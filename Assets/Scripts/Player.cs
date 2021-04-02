using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float SPEED = 0.0f;
    public float ACCELERATION;
    public float RESISTANCE = 0.03f;
    public float TOP_SPEED;
    public float DOWNFORCE = 100f;
    public float BREAKING_FORCE = 5f;
    public int GEAR = 1;
    public int HIGHEST_GEAR = 5;
    public float HIGHEST_TOP_SPEED = 120f;

    bool isColliding = false;
 
    void OnCollisionStay(Collision other)
    {
        isColliding = true;
    }
    void OnCollisionExit(Collision other)
    {
        isColliding = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() {
        transform.Translate(0, 0, SPEED * Time.deltaTime); //forward
        transform.Translate(0, -DOWNFORCE * Time.deltaTime, 0, Space.World); // downforce
    }

    void Update()
    {
        if(isColliding)
        { 
            if (Input.GetKey("up"))
            {
                if (Mathf.Abs(SPEED) < TOP_SPEED)
                    SPEED += ACCELERATION;
            }
            if (Input.GetKey("down"))
            {
                if (SPEED >= 10)
                    SPEED -= BREAKING_FORCE * (1 / Mathf.Abs(SPEED));
                if (SPEED <= -10)
                    SPEED += BREAKING_FORCE * (1 / Mathf.Abs(SPEED));
                if (SPEED > 0 && SPEED < 10)
                    SPEED -= BREAKING_FORCE * 0.25f;
                if (SPEED < 0 && SPEED > -10)
                    SPEED += BREAKING_FORCE * 0.25f;
            }
            if (Mathf.Abs(SPEED) > 0.05f)
            {
                float steeringAngle = (-Mathf.Log(Mathf.Abs(SPEED)+1, 1.12f) + 50);
                int Reverse = GEAR == 0 ? -1 : 1;
                if (Input.GetKey("left"))
                    transform.Rotate(0.0f, Reverse * -(-0.22f*SPEED+50) * Time.deltaTime, 0.0f);
                    //transform.Rotate(0.0f, Reverse * -steeringAngle * Time.deltaTime, 0.0f);
                if (Input.GetKey("right"))
                    transform.Rotate(0.0f, Reverse * (-0.22f * SPEED + 50) * Time.deltaTime, 0.0f);
                    //transform.Rotate(0.0f, Reverse * steeringAngle * Time.deltaTime, 0.0f);
                //Debug.Log(steeringAngle);
            }
        }
        
        if (SPEED > 0.00)
            SPEED -= RESISTANCE;
        if (SPEED < 0.00)
            SPEED += RESISTANCE;


        if (Input.GetKeyDown("a"))
            if (GEAR < HIGHEST_GEAR)
                GEAR++;
        if(Input.GetKeyDown("z"))
            if (GEAR > 0)
                GEAR--;

        switch (GEAR) 
        {
            case 0:
                ACCELERATION = -0.2f;
                TOP_SPEED = 30f;
                break;
            case 1:
                ACCELERATION = 0.13f;
                TOP_SPEED = 40f;
                break;
            case 2:
                ACCELERATION = 0.1f;
                TOP_SPEED = 70f;
                break;
            case 3:
                ACCELERATION = 0.08f;
                TOP_SPEED = 90f;
                break;
            case 4:
                ACCELERATION = 0.06f;
                TOP_SPEED = 100f;
                break;
            case 5:
                ACCELERATION = 0.04f;
                TOP_SPEED = HIGHEST_TOP_SPEED;
                break;
        }

        if (Input.GetKeyDown("left alt"))
        {
            SPEED = 0f;
            transform.Translate(0, 8f, 0, Space.World);
            transform.Rotate(0.0f, 0f, 180f, Space.World);
        }
            
    }
}
