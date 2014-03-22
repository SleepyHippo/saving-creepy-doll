using UnityEngine;
using System.Collections;

public class CustomMouseCursor : MonoBehaviour {

    public int offsetX = -8;
    public int offsetY = -10;
    public Texture2D normal;
    public Texture2D click;
	// Use this for initialization
	void Start () {
        Screen.showCursor=false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        Vector3 msPos=Input.mousePosition;
        if( Input.GetMouseButton(0) )
            GUI.DrawTexture(new Rect(msPos.x + offsetX, Screen.height-msPos.y + offsetY, 100, 100), click);
        else
            GUI.DrawTexture(new Rect(msPos.x + offsetX, Screen.height-msPos.y + offsetY, 100, 100), normal);
            
    }
}
