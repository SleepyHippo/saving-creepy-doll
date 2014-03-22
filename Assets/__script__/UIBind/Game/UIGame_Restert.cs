using UnityEngine;
using System.Collections;

public class UIGame_Restert : MonoBehaviour {

    public GameObject restartWindow;
    public GameObject settingButton;
    // Use this for initialization
    void Start () {
        
    }
    
    // Update is called once per frame
    void Update () {
        
    }
    
    public void OnClick()
    {
        Time.timeScale = 0;
        restartWindow.SetActive(true);
        settingButton.SetActive(false);
        gameObject.SetActive(false);
    }
}
