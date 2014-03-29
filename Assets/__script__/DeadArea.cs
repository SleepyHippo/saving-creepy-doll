using UnityEngine;
using System.Collections;

public class DeadArea : MonoBehaviour {

    public bool showWhenToggleOpen = false;
    public GameObject[] objsToShow;
    public GameObject[] objsToHide;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if( other.CompareTag("Player") )
        {
            other.GetComponent<WudiController>().Die();
            gameObject.SetActive(false);

            foreach(var obj in objsToShow )
            {
                obj.SetActive(true);
            }
            foreach(var obj in objsToHide )
            {
                obj.SetActive(false);
            }
        }
    }

    public void Toggle(bool toggleOpen)
    {
        if( showWhenToggleOpen )
            gameObject.SetActive(toggleOpen);
        else
            gameObject.SetActive(!toggleOpen);
    }
}
