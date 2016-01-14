using UnityEngine;
using System.Collections;

public class Moving : AbducteeBehavior {

    public float moveTime = .1f;
    public LayerMask blockingLayer;



    private float inverseMoveTime;


	// Use this for initialization
	protected virtual void Start () {


        inverseMoveTime = 1f / moveTime;

	}
	
	// Update is called once per frame
	protected virtual void Update () {
	
	}
}
