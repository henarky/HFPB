using UnityEngine;
using System.Collections;

public class TractorBeam : MonoBehaviour {

    
    public bool isBeamed;
    public float beamPull = 0f;
    public bool playerSpotted = false;

    private float offsetY = 0f;
    private FireTractorBeam fireTractorBeam;
    private GameObject tractorBeam;
    private GameObject UFO;
    private Vector2 posUFO;
    private Rigidbody2D abductee;



    // Use this for initialization
    void Awake() {
        UFO = GameObject.FindGameObjectWithTag("Player");


    }

    void Update() {

        posUFO.x = UFO.transform.position.x;
        posUFO.y = UFO.transform.position.y;

        transform.position = new Vector2(posUFO.x, posUFO.y + offsetY);


    }

    void OnTriggerStay2D(Collider2D other) {

        if (other.gameObject.tag == "Human")
        {
            Debug.Log("Target Detected");
            other.GetComponent<Rigidbody2D>().gravityScale = beamPull / 10f;
            other.GetComponent<InstantVelocity>().velocity.x = 0f;
            other.GetComponent<InstantVelocity>().velocity.y = beamPull;
            isBeamed = true;

        } else { isBeamed = false; }

            
    }

}
