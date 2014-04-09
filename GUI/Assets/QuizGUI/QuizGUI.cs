using UnityEngine;
using System.Collections;

public class QuizGUI : MonoBehaviour {
	public string texto = "";
	public string stringarea = "";
	public GUIStyle label;
	public GUIStyle label1;
	public string textota = "";
	public string stringareata = "";
	public GUIStyle labelta;
	public GUIStyle labelta1;
	public Rect windowRect0 = new Rect(10, 20, 500, 400);
	public Rect windowRect1 = new Rect(600, 20, 500, 400);

	void OnGUI(){
		GUI.color = Color.cyan;
		windowRect0 = GUI.Window(0, windowRect0, DoMyWindow0, "ACTIVIDADES");
		GUI.color = Color.magenta;
		windowRect1 = GUI.Window(1, windowRect1, DoMyWindow1, "TAREAS");
		}
	void DoMyWindow0(int windowID) {
		GUI.Label(new Rect(65,25,100,100),"Crear Actividad",label);
		texto = GUI.TextField (new Rect (25, 60, 200, 60), texto);
		GUI.Label(new Rect(275,70,100,100),"Lista de Actividades",label1);
		stringarea = GUI.TextArea (new Rect (250, 100, 200, 200), stringarea);
		if (GUI.Button (new Rect (95, 130, 60, 30), "Agregar")) {
			if(texto!=""){
				stringarea=texto+"\n"+stringarea;
				texto="";
				GUI.DragWindow(new Rect(0, 0, 10000, 10000));
			}
		}
	}

	void DoMyWindow1(int windowID) {
		GUI.Label(new Rect(65,25,100,100),"Crear Tarea",labelta);
		textota = GUI.TextField (new Rect (25, 60, 200, 60), textota);
		GUI.Label(new Rect(294,70,100,100),"Lista de Tareas",labelta1);
		stringareata = GUI.TextArea (new Rect (250, 100, 200, 200), stringareata);
		if (GUI.Button (new Rect (95, 130, 60, 30), "Agregar")) {
			if(textota!=""){
				stringareata=stringareata+textota+"\n";
				textota="";
				GUI.DragWindow(new Rect(0, 0, 10000, 10000));
			}
		}
	}
}