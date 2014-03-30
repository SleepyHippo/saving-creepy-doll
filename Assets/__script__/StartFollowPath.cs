using UnityEngine;
using System.Collections;

public class StartFollowPath : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FollowPath>().StartMove();
    }
}
