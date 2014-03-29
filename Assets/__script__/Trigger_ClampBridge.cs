using System;
using UnityEngine;
using System.Collections;

public class Trigger_ClampBridge : MonoBehaviour {

    public GameObject leftBridge;
    public GameObject rightBridge;

    private TweenRotation leftTweenr;
    private TweenRotation rightTweenr;
	// Use this for initialization
	void Start () {
        leftTweenr = leftBridge.GetComponent<TweenRotation>();
        rightTweenr = rightBridge.GetComponent<TweenRotation>();
	}
	
	// Update is called once per frame
	void Update () {
	
    }

    public void Toggle(bool toggleOpen)
    {
        if( toggleOpen )
        {
            leftTweenr.Play();
            rightTweenr.Play();
        }
        else
        {
            leftTweenr.PlayReverse();
            rightTweenr.PlayReverse();
        }
    }
}
