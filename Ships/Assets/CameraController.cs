using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    // public Transform Target;
    public Transform View;
	// Use this for initialization
	void Start () 
    {
        View = GameObject.FindGameObjectWithTag("Player").transform;
       // Target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void LateUpdate () 
    {
        transform.position = View.position;
       // transform.rotation = View.rotation;
      //  if(Target)
      //     transform.position = Vector3.Lerp(transform.position, Target.position, 10f);
	}
}
