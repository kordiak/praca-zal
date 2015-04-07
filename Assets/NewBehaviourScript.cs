using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {



	public Animator anima;

	public GameObject naWprost;
	public GameObject wLewo;
	public GameObject wPrawo;
	public GameObject gaz;


	public GameObject go;
	int licz=5;
	// Use this for initialization
	void Start () {

		//anim.Play ();

		anima = GetComponent<Animator> ();

		anima.Play("Armature.003|rotRight");
	






		
		//anima.

	}
	
	// Update is called once per frame
	void Update () 
	{
		/*
		licz++;
		if (licz % 500 == 0) 
		{
			anima.Play ("rotLeft");
			//anima.Play ("Exit");	
		}
	*/
	}

}
