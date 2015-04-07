using UnityEngine;
using System.Collections;

public class ClickOnText : MonoBehaviour {


	public GameObject drazekOb;
	public GameObject gaz;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnMouseDown()
	{


		Animator a=drazekOb.GetComponent<Animator>();
		if (this.name == "W prawo" && a.GetCurrentAnimatorStateInfo (0).IsName ("rotLeft")) {
			a.Play ("leftToCenter");

		} else if (this.name == "W prawo") {
			a.Play ("Armature.003|rotRight");

		} else if (this.name == "W lewo" && a.GetCurrentAnimatorStateInfo(0).IsName ("Armature.003|rotRight")) {
			a.Play ("rightToCenter");
		} else if (this.name == "W lewo")
			a.Play ("rotLeft");

	}
}
