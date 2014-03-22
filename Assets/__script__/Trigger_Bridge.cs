using UnityEngine;
using System.Collections;

public class Trigger_Bridge : MonoBehaviour {

	public bool isActive;
	public GameObject model;
	// Use this for initialization
	void Start () {
		model.SetActive(isActive);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter( Collider other ) {
		if( !isActive )
			return;
		if( other.tag == "Player" ){
			other.GetComponent<WudiController>().Jump();
		}
	}

	public void Active(bool active)
	{
		isActive = active;
		model.SetActive(active);
	}
}
