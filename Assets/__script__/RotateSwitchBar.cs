using UnityEngine;
using System.Collections;

public class RotateSwitchBar : MonoBehaviour {

    private TweenRotation rotation;
	// Use this for initialization
	void Start () {
        rotation = GetComponent<TweenRotation>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Toggle(bool toggleOpen)
    {
        if( toggleOpen )
            rotation.Play();
        else
            rotation.PlayReverse();
//        Vector3 temp = rotation.from;
//        rotation.from = rotation.to;
//        rotation.to = temp;
    }
}
