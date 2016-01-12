using UnityEngine;
using System.Collections;

public abstract class AbducteeBehavior : MonoBehaviour {

//    public Buttons[] inputButtons;
    public MonoBehaviour[] disableScripts;

//    protected InputState inputState;
    protected Rigidbody2D abductBody2d;
    protected CollisionState abductCollisionState;

    protected virtual void Awake() {
//        inputState = GetComponent<InputState>();
        abductBody2d = GetComponent<Rigidbody2D>();
        abductCollisionState = GetComponent<CollisionState>();

    }

    protected virtual void ToggleScripts(bool value) {
        foreach (var script in disableScripts) {
            script.enabled = value;
        }

    }

}
