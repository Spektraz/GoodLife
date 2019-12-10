using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOner : MonoBehaviour
{
    private Light light;
	// Use this for initialization
	void Start ()
	{
	    light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.Space))
	    {
	        light.enabled = false;
            
	    }

	    if (Input.GetKey(KeyCode.F))
	    {
	        light.enabled = true;
	    }
	}
}
