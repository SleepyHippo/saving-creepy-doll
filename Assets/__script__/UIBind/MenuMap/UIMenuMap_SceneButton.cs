using UnityEngine;
using System.Collections;

public class UIMenuMap_SceneButton : MonoBehaviour {

    public bool isSelected = false;
    public string levelName;
    public GameObject textSprite;
    private UIMenuMap_SceneButton[] allButtons;
	// Use this for initialization
	void Start () {
	    if( textSprite == null )
            textSprite = transform.FindChild("textSprite").gameObject;
        allButtons = FindObjectsOfType<UIMenuMap_SceneButton>();

        string currentLevel = PlayerPrefs.GetString("Level", "Level01");
        if( currentLevel == levelName )
            SetSelect(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnHover(bool isOver)
    {
        if( isSelected )
            return;
        textSprite.SetActive(isOver);
    }

    public void OnClick()
    {
        foreach(var button in allButtons)
        {
            button.SetSelect(false);
        }
        SetSelect(true);
        
        PlayerPrefs.SetString("Level", levelName);
    }

    public void SetSelect(bool select)
    {
        isSelected = select;
        textSprite.SetActive(select);
    }
}
