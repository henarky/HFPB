﻿using UnityEngine;
using System.Collections;

public class CollisionState : MonoBehaviour {

    public LayerMask collisionLayer;
    public bool bottomUFO;
    public bool sidesUFO;
    public Vector2 bottomPosition = Vector2.zero;
    public Vector2 rightPosition = Vector2.zero;
    public Vector2 leftPosition = Vector2.zero;
    public float collisionRadius = 10f;
    public Color debugCollisionColor = Color.red;

    private InputState inputState;

	// Use this for initialization
	void Awake () {
        inputState = GetComponent<InputState>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate() {

        var pos = bottomPosition;
        pos.x += transform.position.x;
        pos.y += transform.position.y;

        bottomUFO = Physics2D.OverlapCircle(pos, collisionRadius, collisionLayer);

        pos = inputState.direction == Directions.Right ? rightPosition : leftPosition;
        pos.x += transform.position.x;
        pos.y += transform.position.y;

        sidesUFO = Physics2D.OverlapCircle(pos, collisionRadius, collisionLayer);

    }

    void OnDrawGizmos() {
        Gizmos.color = debugCollisionColor;

        var positions = new Vector2[] { rightPosition, bottomPosition, leftPosition };

        foreach (var position in positions) { 

            var pos = position;
            pos.x += transform.position.x;
            pos.y += transform.position.y;

            Gizmos.DrawWireSphere(pos, collisionRadius);
        }
    }
}
