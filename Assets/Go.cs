using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go : MonoBehaviour
{
    public GameObject Hero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.W))
	    {
	        Hero.transform.Translate(Vector3.forward /2 );
	    }

	    if (Input.GetKey(KeyCode.S))
	    {
	        Hero.transform.Translate(Vector3.back /2);
        }

	    if (Input.GetKey(KeyCode.A))
	    {
            Hero.transform.Rotate(0,-1,0);
	    }

	    if (Input.GetKey(KeyCode.D))
	    {
	        Hero.transform.Rotate(0, 1, 0);
        }
	}
}
