using UnityEngine;
using System.Collections;

public class UIGame_ItemButton : MonoBehaviour {

	public GameObject dragImage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnPress(bool isDown)  {
//		Debug.Log("press:" + (go as GameObject).name);
//        Debug.Log("isdown:" + isDown);
		if( isDown )
		{
            dragImage.SetActive(true);
            dragImage.GetComponent<UIGame_DragImage>().MoveToMousePosition();
		}
	}


}
