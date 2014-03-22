using UnityEngine;
using System.Collections;

public class UIGame_WindowRestartNo : MonoBehaviour {

    public GameObject restartWindow;
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
        restartWindow.SetActive(false);
        restartButton.SetActive(true);
        settingButton.SetActive(true);
    }
}
