using UnityEngine;
using System.Collections;

public class CharSelector : MonoBehaviour {

    public GameObject[] chars;
    public int currentIndex = 0;
	// Use this for initialization
	void Start () {
        Show(currentIndex);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ShowPrev()
    {
        currentIndex--;
        if( currentIndex < 0 )
            currentIndex += chars.Length;
        Show(currentIndex);
    }

    public void ShowNext()
    {
        currentIndex++;
        if( currentIndex >= chars.Length )
            currentIndex = 0;
        Show(currentIndex);
    }

    private void Show(int index)
    {
        if( index >= chars.Length )
            return;
        foreach(GameObject c in chars )
        {
            c.SetActive(false);
        }
        chars[index].SetActive(true);
    }
}
