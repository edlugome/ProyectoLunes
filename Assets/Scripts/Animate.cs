using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour 
{
	//public RectTransform Circle;
	//public float Rotation;
	public Animator animator;
	public bool asd;
	void Awake()
	{
		asd = true;
		animator =GameObject.FindWithTag("AC").GetComponent<Animator> ();
	}
	// Update is called once per frame
	void FixedUpdate () 
	{
	//	Circle.Rotate (0,0,Rotation);
	}

	public void FuncionAparte()
	{
		animator.SetTime (10.0f);
	}

	public void detener()
	{
		if (asd)
		{
			animator.StartPlayback (); 
			asd = false;
		} 

		else if(!asd)
		{
			animator.StopPlayback ();
			asd = true;
		}
	}
	public void start()
	{
		
		animator.StopPlayback ();
		animator.SetBool ("exercise", true);
	}

	public void stop()
	{
		//animator.SetTime (1);
		//animator.StartPlayback ();
		animator.SetBool ("exercise", false);
		//animator.speed = 0;

		animator.Play ("default");

		//animator.SetBool ("exercise", false);
	}

	public void otracosa()
	{

	}
		
}
