using UnityEngine;
using System.Collections;

public class Taller : MonoBehaviour {

	float color,colog,colob =0;
	int banc,bane,bancy,banp =0;
	GameObject plane1;
	GameObject cylinder3;
	GameObject sphere1;
	GameObject cube1;
	public GUIStyle style;
	public GUIStyle style2;
	public GUIStyle stybox;
	public GUIStyle label;

	void OnGUI(){
		GUI.Box(new Rect(0,0,Screen.width/2,Screen.height),"Menu Opciones", stybox);
		GUI.Label (new Rect (0, 50, 200, 40), "Crear Objetos",label);
		GUI.Label (new Rect (0, 170, 200, 40), "Cambiar Color de los Objetos",label);
		GUI.Label (new Rect (0, 190, 200, 40), "Colores rojizos",label);
		GUI.Label (new Rect (0, 225, 200, 40), "Colores verdosos",label);
		GUI.Label (new Rect (0, 255, 200, 40), "Colores azulados",label);

		if (banc == 0) {
		if (GUI.Button (new Rect (0, 100, 50, 50), "CUBO", style)) {
		cube1 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube1.transform.position = new Vector3 (0f, 0f, 0f);
		cube1.transform.Rotate (0f, 0f, 0f);
		cube1.transform.localScale = new Vector3 (1f, 1f, 1f);
		banc++;
		}
		}
		if (bane == 0) {
		if (GUI.Button (new Rect (60, 100, 55, 50), "ESFERA", style)) {
		sphere1 = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		sphere1.transform.position = new Vector3 (3f, 0f, 0f);
		sphere1.transform.Rotate (0f, 0f, 0f);
		sphere1.transform.localScale = new Vector3 (1f, 1f, 1f);
		bane++;
		}
		}
		if (bancy == 0) {
	    if (GUI.Button (new Rect (120, 100, 50, 50), "Cylindro", style)) {
		cylinder3 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		cylinder3.transform.position = new Vector3 (6, 0f, 0f);
		cylinder3.transform.Rotate (0f, 0f, 0f);
		cylinder3.transform.localScale = new Vector3 (2f, 2f, 2f);
		bancy++;
		}
		}
		if (banp == 0) {
		if (GUI.Button (new Rect (180, 100, 50, 50), "Plano", style)) {
		plane1 = GameObject.CreatePrimitive (PrimitiveType.Plane);
		plane1.transform.position = new Vector3 (0f, 0f, 0f);
		plane1.transform.Rotate (0f, 0f, 0f);
		plane1.transform.localScale = new Vector3 (1f, 1f, 1f);
		banp++;
		}
		}
		color = GUI.HorizontalSlider (new Rect(0, 210, 250, 30),color, 0.0f, 1.0f);
		colog = GUI.HorizontalSlider (new Rect(0, 240, 250, 30),colog, 0.0f, 1.0f);
		colob = GUI.HorizontalSlider (new Rect(0, 270, 250, 30),colob, 0.0f, 1.0f);
}
	 void Update(){
		if(cube1 != null)
		   cube1.renderer.material.color=new Color(color,colog,colob);
		if(sphere1 != null)
		   sphere1.renderer.material.color=new Color(color,colog,colob);
		if(cylinder3 != null)
		   cylinder3.renderer.material.color=new Color(color,colog,colob);
		if(plane1 != null)
		   plane1.renderer.material.color=new Color(color,colog,colob);
			}
	}