using System;
using UnityEngine;
using System.Collections;

public class Trigger_SetMovementSpeed : MonoBehaviour {

    public float moveSpeed;
    public float reversedSpeed;
    public bool resetSpeedWhenExit = true;

    private float speed;
    private WudiController controller;
    private float originSpeed;
	// Use this for initialization
	void Start () {
        speed = moveSpeed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if( other.CompareTag("Player") )
        {
            controller = other.GetComponent<WudiController>();
            originSpeed = controller.moveSpeed;
            controller.moveSpeed = speed;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if( other.CompareTag("Player") )
        {
            if( resetSpeedWhenExit && controller.moveSpeed > 0)
            {
                controller.moveSpeed = originSpeed;
            }
        }
    }

    public void Toggle(bool toggleOpen)
    {
        if ( toggleOpen )
            speed = reversedSpeed;
        else
            speed = moveSpeed;
    }
}
