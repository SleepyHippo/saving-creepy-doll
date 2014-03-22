using UnityEngine;
using System.Collections;

public class TriggerDropArea : MonoBehaviour {

	public bool isActive;
	public GameObject trap;
	// Use this for initialization
	void Start () {
		trap.SetActive(isActive);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Active(bool active)
	{
		trap.SetActive(active);
	}
}
