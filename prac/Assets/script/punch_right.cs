﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punch_right : MonoBehaviour
{
    Rigidbody r;
    Vector3 target_box;
    Vector3 origin;
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
        r = GetComponent<Rigidbody>();
        target_box = new Vector3(2.4f, 0.76f, 0.31f);
    }

    // Update is called once per frame
    void Update()
    {
        target_box = new Vector3(2.4f, 0.76f, 0.31f);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
          
            transform.position = Vector3.MoveTowards(transform.position, target_box, 3f);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, origin, 3f);

        }

    }

    public void rightdown()
    {
        transform.position = Vector3.MoveTowards(transform.position, target_box, 3f);

    }
    public void rightup()
    {
        transform.position = Vector3.MoveTowards(transform.position, origin, 3f);

    }

}
