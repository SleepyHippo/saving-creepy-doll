using UnityEngine;
using System.Collections;

public class UIMenuItem_Next : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        Application.LoadLevel(PlayerPrefs.GetString("Level"));
    }
}
