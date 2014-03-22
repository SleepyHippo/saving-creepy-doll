using UnityEngine;
using System.Collections;

public class UIGame_WindowEndNext : MonoBehaviour {

    public string nextLevel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        Time.timeScale = 1.0f;
        Application.LoadLevel(nextLevel);
    }
}
