﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLogic : MonoBehaviour
{
    bool movable = true;
    float timer = 0f;
    public GameObject rig;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movable)
        { 
             //Update the timer
             timer += 1 * Time.deltaTime;

            //Drop
            if(Input.GetKey(KeyCode.DownArrow) && timer > GameLogic.quickDropTime)
            {
                 gameObject.transform.position -= new Vector3(0, 1, 0);
                 timer = 0;
             }

            else if(timer > GameLogic.dropTime)
            {
                gameObject.transform.position -= new Vector3(0, 1, 0);
                timer = 0;
            }
           
            //Sideways
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                gameObject.transform.position -= new Vector3(1, 0, 0);
            }

            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                gameObject.transform.position += new Vector3(1, 0, 0);
            }

            //Rotation
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rig.transform.eulerAngles -= new Vector3(0, 0, 90);

            }
        }
    }
}
