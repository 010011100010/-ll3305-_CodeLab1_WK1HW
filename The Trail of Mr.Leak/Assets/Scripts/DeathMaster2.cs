using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMaster2 : MonoBehaviour {
    public GameObject button2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "P2")
        {
            Debug.Log("P2 hit");
            //GameObject newCanvas1 = Instantiate(canvas1) as GameObject;
            // GameObject newButton1 = Instantiate(button1) as GameObject;
            // newButton1.transform.SetParent(newCanvas1.transform, false);
            //newButton1.transform = new Vector2(0, 0);
            Instantiate(button2, new Vector2(0, 0), Quaternion.identity);
            Time.timeScale = 0;
        }
    }
}
