using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("SPHERE PLACED at: ");
        }
	}
}
