using UnityEngine;
using System.Collections;

public class SelfRotating : MonoBehaviour {

    public Vector3 axis;
    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(axis, speed * Time.deltaTime, Space.World);
	}

    public void Toggle()
    {
        speed *= -1;
    }
}
