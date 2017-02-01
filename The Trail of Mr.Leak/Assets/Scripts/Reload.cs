using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1;
            Application.LoadLevel(0);
        }
    }

    public void RestartGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
