using UnityEngine;
using System.Collections;

public class UIMenu_Setting : MonoBehaviour {

    public GameObject selector;
	// Use this for initialization
	void Start () {
	    if( selector == null )
            selector = GameObject.Find("Selector");
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void OnHover()
    {
        selector.SetActive(true);
        selector.transform.parent = transform;
        selector.transform.localPosition = Vector3.zero;
    }

    public void OnClick()
    {
        selector.SetActive(true);
        selector.transform.parent = transform;
        selector.transform.localPosition = Vector3.zero;

    }
}
