using UnityEngine;
using System.Collections;


public class cube_scale : MonoBehaviour {
	public static float x;
	public static float y;
	public static float z;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		x = transform.localScale.x;
		y = transform.localScale.y;
		z = transform.localScale.z;
		if (Input.GetAxis ("Mouse ScrollWheel") > 0) {
			transform.localScale += new Vector3 (0.1F, 0.1F, 0.1F);
		};
		if (Input.GetAxis("Mouse ScrollWheel") < 0) {
			if (transform.localScale.x > 1) {
				transform.localScale += new Vector3 (-0.1F, -0.1F, -0.1F);
			}
		}
	}

}
