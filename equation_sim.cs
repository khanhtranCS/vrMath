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
		Debug.Log(object_scale.x);
		GetComponent<TextMesh>().text ="x: " + object_scale.x + " y: " + object_scale.y + "z " + object_scale.z;

	}
}
