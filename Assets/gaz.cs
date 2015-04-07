using UnityEngine;
using System.Collections;

public class gaz : MonoBehaviour {

	private Animator anim;
	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();
		anim.Play("go");
	}
	
	// Update is called once per frame
	void Update () 
	{
		//anim.Play ("stop");
	
	}
}
