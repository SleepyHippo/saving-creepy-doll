using UnityEngine;
using System.Collections;

public class Trigger_Switch : MonoBehaviour {

//	public bool isActive;
//	public GameObject model;
	// Use this for initialization
    public bool open = false;
    public GameObject[] targets;
	void Start () {
//		model.SetActive(isActive);
	}
	
    void OnEnable()
    {
        open = !open;
        if( targets.Length > 0 )
        {
            foreach(var target in targets)
            {
                target.SendMessage("Toggle", open);
            }
        }
        gameObject.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
	
	}	
}
