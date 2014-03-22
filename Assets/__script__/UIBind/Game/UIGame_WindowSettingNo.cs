using UnityEngine;
using System.Collections;

public class UIGame_WindowSettingNo : MonoBehaviour {

    public GameObject settingWindow;
    public GameObject restartButton;
    public GameObject settingButton;
    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        
    }
    
    public void OnClick()
    {
        Time.timeScale = 1.0f;
        settingWindow.SetActive(false);
        restartButton.SetActive(true);
        settingButton.SetActive(true);
    }
}
