using UnityEngine;
using System.Collections;

public class HideOtherWhenEnable : MonoBehaviour {

    public GameObject[] objsToHide;
	// Use this for initialization
	void Start () {
        foreach(var obj in objsToHide)
        {
            obj.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
