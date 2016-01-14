using UnityEngine;
using System.Collections;

public abstract class AbducteeBehavior : MonoBehaviour {

//    public Buttons[] inputButtons;
    public MonoBehaviour[] disableScripts;

//    protected InputState inputState;
    protected Rigidbody2D abductBody2d;
    protected CollisionState abductCollisionState;
    protected BoxCollider2D boxCollider;

    protected virtual void Awake() {
//        inputState = GetComponent<InputState>();
        abductBody2d = GetComponent<Rigidbody2D>();
        abductCollisionState = GetComponent<CollisionState>();
        boxCollider = GetComponent<BoxCollider2D>();

    }

    protected virtual void ToggleScripts(bool value) {
        foreach (var script in disableScripts) {
            script.enabled = value;
        }

    }

}
