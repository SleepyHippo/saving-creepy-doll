using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UIGame_DragImage : MonoBehaviour {

	public string itemIndex;
	public List<GameObject> targets;

    private float ratio = 0;

	void Start () {
        ratio = 1080.0f / Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
//        Debug.Log(transform.localPosition);
        if( Input.GetMouseButtonUp(0) )
            OnMouseUp();
        MoveToMousePosition();
	}

	void OnMouseUp() 
    {
//		Debug.Log("drop" + drag.name);
		foreach(GameObject target in targets)
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit info = new RaycastHit();
			if( target.collider.Raycast(ray, out info, 1000) )
			{
				Debug.Log(info.collider.name);
				info.collider.gameObject.SetActive(true);
				info.collider.SendMessage("Active", true);
			}
		}
        gameObject.SetActive(false);
	}

    public void MoveToMousePosition()
    {
        if (System.Math.Abs (ratio - 0) < Mathf.Epsilon)
            ratio = 1080.0f / Screen.height;
        Vector3 mouse = Input.mousePosition;
        transform.localPosition = mouse * ratio;
    }
}
