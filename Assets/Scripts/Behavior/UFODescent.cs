using UnityEngine;
using System.Collections;

public class UFODescent : AbstractBehavior {
	public float descentDistance = 150f;
	public float dspeed = -300f;
	private Animator anim;
	private FireTractorBeam fire;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		fire = GetComponent<FireTractorBeam> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (descentDistance > 0) {
			Vector2 desc = new Vector2 (0, dspeed);
			body2d.AddForce (desc);
			descentDistance -= 1;
			dspeed += 1;
		} else {
			if (anim.GetInteger ("AnimState") != 1) {
				anim.SetInteger ("AnimState", 1);
				fire.canBeam = true; //comment out once bound to animstate
			}
			/*
			else if (anim.IsInTransition(0) && anim.GetCurrentAnimatorStateInfo{
				fire.canBeam = true; */
			//}
		}
	}
}
