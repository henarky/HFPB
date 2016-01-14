using UnityEngine;
using System.Collections;

public class FireTractorBeam : AbstractBehavior {

    public float shootDelay = .5f;
    public GameObject projectilePrefab;
    public Vector3 firePosition = Vector3.zero;
    public Color debugColor = Color.green;
    public float debugRadius = 3;

    private float timeElapsed = 0f;
	
	// Update is called once per frame
	void Update () {
        if (projectilePrefab != null) {

            var canFire = inputState.GetButtonValue(inputButtons[0]);

            if (canFire && timeElapsed > shootDelay) {
                CreateProjectile(CalculateFirePosition());
                timeElapsed = 0;
            }

            timeElapsed += Time.deltaTime;
        }
	}

    Vector3 CalculateFirePosition() {
        var pos = firePosition;
//        pos.x *= (float)inputState.direction;
        pos.x += transform.position.x;
        pos.y += transform.position.y;
        pos.z += projectilePrefab.transform.position.z;

        return pos;

    }



    public void CreateProjectile(Vector3 pos) {

        var clone = Instantiate(projectilePrefab, pos, Quaternion.identity) as GameObject;
        clone.transform.localScale = projectilePrefab.transform.localScale;
    }

    void OnDrawGizmos() {
        Gizmos.color = debugColor;
        var pos = firePosition;

        if (inputState != null)
        pos.x *= (float)inputState.direction;
        pos.x += transform.position.x;
        pos.y += transform.position.y;
        Gizmos.DrawWireSphere(pos, debugRadius);
    }
}
