using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    private InputState inputState;
    private Fly flyBehavior;
    private Animator animator;
    private CollisionState collisionState;
//    private Duck duckBehavior;


    void Awake() {
        inputState = GetComponent<InputState>();
        flyBehavior = GetComponent<Fly>();
        animator = GetComponent<Animator>();
        collisionState = GetComponent<CollisionState>();
//        duckBehavior = GetComponent<Duck>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (collisionState == null) {
            ChangeAnimationState(0);
        }

        if (inputState.absVelX > 0) {
            ChangeAnimationState(1);
            animator.speed = flyBehavior.running ? flyBehavior.runMultiplier : 1;
        }

        if (inputState.absVelY > 0) {
            ChangeAnimationState(2);
        }

//        if (duckBehavior.ducking) {
//            ChangeAnimationState(3);
//        }

//        if (!collisionState.bottomUFO && collisionState.sidesUFO) {
//            ChangeAnimationState(4);
//        }

    }

    void ChangeAnimationState(int value) {
        animator.SetInteger("AnimState", value);

    }

}
