using UnityEngine;
using System.Collections;

public class ShowHideWhenToggle : MonoBehaviour {

    public GameObject[] objs;
	// Use this for initialization
	void Start () {

	}

    void Toggle(bool toggleOpen)
    {
        foreach(var obj in objs)
        {
            obj.SetActive(toggleOpen);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
