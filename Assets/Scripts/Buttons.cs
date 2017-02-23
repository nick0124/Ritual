using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

    public string levelName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayGame()
    {
        Application.LoadLevel(levelName);
    }
}
