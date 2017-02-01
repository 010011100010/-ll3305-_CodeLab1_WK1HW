using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailSpawnScript : MonoBehaviour {
    public Vector3 P1;
    public Vector3 P2;
    public GameObject trail1;
    public GameObject trail2;
    private int frames = 0;
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        P1 = GameObject.Find("Player 1").transform.position;
        P2 = GameObject.Find("Player 2").transform.position;
        //Debug.Log("P1 at " + P1);
        //Debug.Log("P2 at " + P2);
        frames++;
        if (frames % 20 == 0)
        { //If the remainder of the current frame divided by 10 is 0 run the function.
            Frame10Update();
        }
    }

    void Frame10Update()
    {
        Instantiate(trail1, P1, Quaternion.identity);
      
        Instantiate(trail2, P2, Quaternion.identity);
        
    }
}
