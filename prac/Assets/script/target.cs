﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    Rigidbody r;
    public Transform box;
    public Transform box2;
   // public controller ct;
    Vector3 target_b;
    Vector3 original_p;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
        target_b = (box.position + box2.position) / 2;
        original_p = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,target_b , 0.1f);
        if (transform.position == target_b)
        {
            Invoke("f", 2f);
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="hand")
        {// this.gameObject.SetActive(false);

            controller.score++;
            //  GetComponent<Speed>().speed = collision.gameObject.GetComponent<FistSpeed>().CurrentSpeed;

            // speed라는게 원래 있는 건가 보데..?
     
            /*   Vector3 CurrentSpeed=GetComponent<FistSpeed>().CurrentSpeed;// 이런식으로 가져오는 거구나...
            if (CurrentSpeed.magnitude > 10)
            {
               
            }
            */
            GetComponent<MeshExploder>().Explode();// 깨지는 이미지 구현한거 
            //  Instantiate<GameObject>(AfterEffect,transform,true); // 폭발 하는거 

            Debug.Log("score: " + controller.score);
            Invoke("f", 2f);
            Debug.Log("colli : " + collision.gameObject.tag);
        }
       
    }
    private void f()
    {
        this.gameObject.SetActive(false);
        this.transform.position = original_p;
        this.gameObject.SetActive(true);
        transform.position = Vector3.MoveTowards(transform.position, target_b, 0.1f);
    }
}
