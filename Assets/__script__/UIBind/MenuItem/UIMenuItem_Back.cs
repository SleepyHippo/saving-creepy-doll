using UnityEngine;
using System.Collections;

public class UIMenuItem_Back : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        Application.LoadLevel("MenuChar");
    }
}
