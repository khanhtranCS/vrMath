## MathVR

MathVR helps teach people how the world around them can be described with mathematics. Players are thrown into a pre-made environment that they can explore using VR. In this environment, the physical properties of 3D objects can be changed in real time by manipulating formulas.

### Contributers:
Ryan Proffitt, Khanh Tran, Jediah Conachan, Sandip Samantary, Quyen Truong

### Email:
+ Ryan Proffitt: ryan.d.proffitt@gmail.com
+ Khanh Tran: ktran035@uw.edu
+ Jediah Conachan: jediah6@gmail.com
+ Sandip Samantary: xenosis@sandips.xyz
+ Quyen Truong: quyent22@uw.edu

### Objectives:

Create a cube in Unity
Use Unity as the 3D virtual environment
Attach scripts as components
Scripting Phase I
We need the camera to be from the perspective of the player through the Oculus.
We need to be able to look at an object and click left mouse button to select it.
We need to be able to scroll a mouse wheel to change the size of the cube.
We need to be able to move the player character around.
Scripting Phase II
We need to be able to see the formulas that make up the geometric properties of the cube.
HUD? User Interface Window in-game?
We need to be able to manipulate individual values of variables in the formulas.
We need the manipulated variables to change the physical properties of the cube in real-time.
```
public class ScaleCube : MonoBehaviour {
	public float resizer = 0;
	
	if(Input.GetAxis("Mouse Scrollwheel") > 0){
		Vector3 vector = new Vector3(transform.localScale.x++, transform.localscale.y++,                              transform.localscale.z++);
		transform.localScale = vector;
	}
	if(Input.GetAxis("Mouse Scrollwheel") < 0){
		if(Transform.localScale.x > 1){
			Vector3 vector = new Vector3(transform.localScale.x--, transform.localscale.y--,                  transform.localscale.z--);
		}
	}
}
```