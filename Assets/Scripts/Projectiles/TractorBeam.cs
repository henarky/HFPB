using UnityEngine;
using System.Collections;

public class TractorBeam : MonoBehaviour {

    
    public bool isBeamed;
    public float gravityHuman = 5f;

    private float offsetY = 0f;
    private GameObject UFO;

    private InstantVelocity instantVelocity;


    // Use this for initialization
    void Awake() {
        instantVelocity = GetComponent<InstantVelocity>();

    }

    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector2(UFO.transform.position.x, UFO.transform.position.y + offsetY);

    }

    void OnTriggerEnter2D(Collider2D other) {
        var Vel = instantVelocity.velocity.y;
        Vel = 50f;
        if (other.tag == "Human") {
//            var Vel = instantVelocity.velocity.y;
//            Vel = 50f;
            
        }

    }


    void tractorBeamPhysics() {


           

    }

}
