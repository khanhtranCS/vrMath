using UnityEngine;
using System.Collections;

public class object_scale : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
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
