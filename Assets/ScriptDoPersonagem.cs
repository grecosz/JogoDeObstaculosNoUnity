﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDoPersonagem : MonoBehaviour
{
    public Vector3 mov; 

    // Start is called before the first frame update
    void Start()
    {
Debug.Log("inicio");
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.LeftArrow))
        {
       
            mov.x = 0.0f;
            mov.y = 0.0f;
            mov.z = -0.5f;

            transform.Translate(mov);

        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            mov.x = 0.0f;
            mov.y = 0.0f;
            mov.z = 0.50f;

            transform.Translate(mov);
        }

         if(Input.GetKey(KeyCode.UpArrow))
        {
            mov.x = 0.0f;
            mov.y = 0.5f;
            mov.z = 0.0f;

            transform.Translate(mov);
        }

    }
}
