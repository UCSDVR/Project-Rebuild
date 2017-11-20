﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Debug.Log("rindextrigger pressed");
        }
        if (OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger))
        {
            Debug.Log("rindextrigger released");
        }
    }
}
