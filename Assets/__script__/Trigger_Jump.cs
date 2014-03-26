using UnityEngine;
using System.Collections;

public class Trigger_Jump : MonoBehaviour {

//	public bool isActive;
//	public GameObject model;
	// Use this for initialization
    public float scale = 1.0f;
    public Vector3 jumpDir = Vector3.up;
    public GameObject[] objsToInactivate;
	void Start () {
//		model.SetActive(isActive);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter( Collider other ) {
//		if( !isActive )
//			return;
		if( other.tag == "Player" ){
            other.GetComponent<WudiController>().Jump(scale, jumpDir);
            foreach(var obj in objsToInactivate)
            {
                obj.SetActive(false);
            }
		}
	}

//	public void Active(bool active)
//	{
//		isActive = active;
//		model.SetActive(active);
//	}
}
