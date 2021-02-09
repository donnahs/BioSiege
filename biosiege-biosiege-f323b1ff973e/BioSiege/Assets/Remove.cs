using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Remove : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        GameObject.Destroy(GameObject.Find("TextureBufferCamera"));
        XRSettings.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
