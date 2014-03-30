using UnityEngine;
using System.Collections;

public class FollowPath : MonoBehaviour {

    public bool startMove;
    public WudiController controller;
    public float moveSpeed;
    public Transform[] path;

    private int currentIndex;
    
    // Use this for initialization
	void Start () {
//        StartMove();
	}
	
	// Update is called once per frame
	void Update () {
	    if( startMove )
        {
            Transform target = path[currentIndex];
            if( ReachTarget(target ) )
            {
                currentIndex++;
                if( currentIndex == path.Length )
                {
                    controller.enabled = true;
                    startMove = false;
                    rigidbody.isKinematic = false;
                }
                return;
            }
            else
            {
                Vector3 dir = (target.position - transform.position).normalized;
                Vector3 movement = dir * moveSpeed * Time.deltaTime;
                transform.Translate(movement, Space.Self);
            }
        }
	}

    public void StartMove()
    {
        controller.enabled = false;
        startMove = true;
        rigidbody.isKinematic = true;
        transform.position = path[0].position;
    }

    private bool ReachTarget(Transform target)
    {
        if( Vector3.Distance(this.transform.position, target.position) < 0.1f )
            return true;
        else 
            return false;
    }
}
