using UnityEngine;
using System.Collections;

public class Trigger_Bomb : MonoBehaviour {

//	public bool isActive;
//	public GameObject model;
    public GameObject particle;
    public GameObject[] objsToHide;
	// Use this for initialization
	void Start () {
//		model.SetActive(isActive);
        Invoke("Bomb", 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void Bomb()
    {
        gameObject.SetActive(false);
        if( particle != null )
            Object.Instantiate(particle, transform.position, transform.rotation);
        foreach(var obj in objsToHide)
        {
            obj.SetActive(false);
        }
    }
//	void OnTriggerEnter( Collider other ) {
////		if( !isActive )
////			return;
//		if( other.tag == "Player" ){
//			other.GetComponent<WudiController>().Jump();
//		}
//	}

//	public void Active(bool active)
//	{
//		isActive = active;
//		model.SetActive(active);
//	}
}
