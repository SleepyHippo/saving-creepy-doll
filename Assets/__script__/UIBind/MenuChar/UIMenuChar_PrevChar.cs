﻿using UnityEngine;
using System.Collections;

public class UIMenuChar_PrevChar : MonoBehaviour {

    public CharSelector charSelector;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        charSelector.ShowPrev();
    }
}
