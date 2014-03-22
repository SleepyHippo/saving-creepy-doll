using UnityEngine;
using System.Collections;

public class UIMenuChar_Next : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        Application.LoadLevel("MenuItem");
    }
}
