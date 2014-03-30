using UnityEngine;
using System.Collections;

public class SetParentOnEnter : MonoBehaviour {

    public GameObject target;
    public GameObject targetParent;
    public Vector3 offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        target.transform.parent = targetParent.transform;
        target.transform.localPosition = offset;
        gameObject.SetActive(false);
        targetParent.GetComponentInChildren<Animator>().SetBool("isIdle", true);
        targetParent.GetComponent<FollowPath>().moveSpeed = 8;
    }
}
