using UnityEngine;
using System.Collections;

public class UIGame_Setting : MonoBehaviour {

    public GameObject settingWindow;
    public GameObject restartButton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        Time.timeScale = 0;
        settingWindow.SetActive(true);
        restartButton.SetActive(false);
        gameObject.SetActive(false);
    }
}
