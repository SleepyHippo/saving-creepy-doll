using UnityEngine;
using System.Collections;

public class Trigger_Climb : MonoBehaviour {

	public bool climbUp;
	public GameObject startPoint;
	public GameObject endPoint;
	public GameObject leavePoint;
    public GameObject[] objsToInactivate;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter( Collider other ) {
		if( other.tag == "Player" ){
			other.GetComponent<WudiController>().Climb(climbUp, startPoint, endPoint, leavePoint);
            foreach(var obj in objsToInactivate)
            {
                obj.SetActive(false);
            }
		}
	}
}
