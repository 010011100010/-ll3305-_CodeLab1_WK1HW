using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMaster : MonoBehaviour {
    //public GameObject canvas1;
    public GameObject button1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "P1")
        {
            Debug.Log("P1 hit");
            //GameObject newCanvas1 = Instantiate(canvas1) as GameObject;
           // GameObject newButton1 = Instantiate(button1) as GameObject;
           // newButton1.transform.SetParent(newCanvas1.transform, false);
            //newButton1.transform = new Vector2(0, 0);
            Instantiate(button1, new Vector2(0, 0), Quaternion.identity);
            Time.timeScale = 0;
        }
    }
}
