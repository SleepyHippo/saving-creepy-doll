using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WudiController : MonoBehaviour {

	public float moveSpeed;
	public float jumpSpeed;
	public float climbSpeed;
//	public bool isJump;
//	public float verticalSpeed;

	private bool run;
	private bool climb;
	private Vector3 climbDirection;
	private GameObject climbEndPoint;
	private GameObject climbLeavePoint;
	private Animator anim;

	// Use this for initialization
	void Start () {
		run = true;
		anim = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate() {
		float deltaTime = Time.deltaTime;

		Vector3 movement = Vector3.zero;
		if( run )
			movement += Vector3.right * moveSpeed * deltaTime;
		else if( climb )
		{
			if( Mathf.Abs(transform.position.y - climbEndPoint.transform.position.y) < 0.1f )
			{
				climb = false;
				run = true;
				anim.SetBool("isClimbUp", false);
				anim.SetBool("isClimbDown", false);
				rigidbody.isKinematic = false;
				
				transform.position = climbLeavePoint.transform.position;
				transform.rotation = climbLeavePoint.transform.rotation;
			}
			else
				movement += climbDirection.normalized * climbSpeed * deltaTime;
		}
        else
        {
            return;
        }

//		verticalSpeed += Physics.gravity.y * deltaTime;
//		if( verticalSpeed < 0 )
//			verticalSpeed = 0;

//		Vector3 verticalVelocity = Vector3.up * verticalSpeed * deltaTime;

//		if( isJump )
//			movement += verticalVelocity;
	
		transform.Translate(movement, Space.Self);
	}

    public void Stop()
    {
        run = false;
    }

    public void Run()
    {
        run = true;
    }

	public void Jump()
	{
//		isJump = true;
//		verticalSpeed = jumpSpeed;
		rigidbody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
		anim.SetBool("isJump", true);
		StartCoroutine(waitAndStopJump());
	}

	IEnumerator waitAndStopJump(){
		yield return new WaitForSeconds(0.7f);
//		isJump = false;
		anim.SetBool("isJump", false);

	}

	public void Climb(bool climbUp, GameObject startPoint, GameObject endPoint, GameObject leavePoint)
	{
		climb = true;
		run = false;
		anim.SetBool(climbUp ? "isClimbUp" : "isClimbDown", true);
		rigidbody.isKinematic = true;

		climbDirection = endPoint.transform.position- startPoint.transform.position;
		climbEndPoint = endPoint;
		climbLeavePoint = leavePoint;

		transform.position = startPoint.transform.position;
		transform.rotation = startPoint.transform.rotation;
	}

    public void Die()
    {
        (Camera.main.GetComponent("SmoothFollow") as MonoBehaviour).enabled = false;
        run = false;
        anim.SetBool("isDead", true);
        StartCoroutine(WaitAndRestart(3.0f));
    }

    IEnumerator WaitAndRestart(float time)
    {
        yield return new WaitForSeconds(time);

        Application.LoadLevel(Application.loadedLevelName);
    }
}
