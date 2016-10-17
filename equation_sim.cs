using UnityEngine;
using System.Collections;
using System;
using System.IO;

public class equation_sim : MonoBehaviour {
	//object_scale curr_cube;
	TextMesh dyn_text;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//curr_cube = GetComponent<object_scale>();
		//Vector3 dim = curr_cube.getDimension();
		double x = Math.Round(cube_scale.x,2);
		double y = Math.Round(cube_scale.y,2);
		double z = Math.Round(cube_scale.z,2);

		string info = "x: " + x + " y: " + y + "z " + z + Environment.NewLine;
		string vol = "Volume: " + x + " * " + y + " * " + z + " = " + Math.Round((x * y * z),2) + Environment.NewLine;
		string sfa = "surface Area: " + "6 * " + x + "^2 = " + Math.Round((6 * Math.Pow(x,2)), 2); 
		GetComponent<TextMesh> ().text = info + vol + sfa;

	}
}
