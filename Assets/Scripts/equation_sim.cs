using UnityEngine;
using System.Collections;


public class equation_sim : MonoBehaviour {
	//object_scale curr_cube;
	TextMesh dyn_text;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//curr_cube = GetComponent<object_scale>();
		//Vector3 dim = curr_cube.getDimension();
		Debug.Log(cube_scale.x);
		GetComponent<TextMesh>().text ="x: " + cube_scale.x + " y: " + cube_scale.y + "z " + cube_scale.z;

	}
}
