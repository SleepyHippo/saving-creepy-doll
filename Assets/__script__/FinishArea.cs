﻿using UnityEngine;
using System.Collections;

public class FinishArea : MonoBehaviour {

    public GameObject[] objsToShow;
    public GameObject[] objsToHide;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if( other.CompareTag("Player") )
        {
            other.GetComponent<WudiController>().Stop();
            foreach(var obj in objsToShow )
            {
                obj.SetActive(true);
            }
            foreach(var obj in objsToHide )
            {
                obj.SetActive(false);
            }
        }
    }
}
