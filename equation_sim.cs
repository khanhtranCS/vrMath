using UnityEngine;
using System.Collections;

public class equation_sim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		object_scale cube_obj = GetComponent(object_scale);
		Vector3 cube_dim = cube_obj.getDimension();
		Text txt = gameObject.GetComponent<Text>();
		txt.text = cube_dim.x + "" + cube_dim.y + "" + cube_dim.z;
	}
}
