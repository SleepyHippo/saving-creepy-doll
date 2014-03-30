using UnityEngine;
using System.Collections;

public class UIMenuItem_ItemDescription : MonoBehaviour {

    public UILabel label;
    public string description;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnHover()
    {
        label.text = description;
    }

    void OnClick()
    {
        label.text = description;
    }
}
