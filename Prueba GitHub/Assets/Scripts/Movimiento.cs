using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {

	Rigidbody2D rg; //Esto variable es para utilizar el Rigidbody del Objeto
	public float fuerza = 200f; //variable de fuerza de salto
	public float velocidad_pollo = 200f; //variable de fuerza de movimiento.
	Vector3 mira_derecha = new Vector3(-2,2,2);
	Vector3 mira_izquierda = new Vector3(2,2,2);

	// Use this for initialization

	void Start () {
		rg = GetComponent<Rigidbody2D>(); //Asignamos y cargamos los datos del componente
	}
	
	// Update is called once per frame
	void Update () {
		//Si pulsamos espacio, saltamos
		if (Input.GetKeyDown (KeyCode.Space)) {
			salto ();
		}

		if (Input.GetKey (KeyCode.A)) {
			mueve_izquierda ();
		}

		if (Input.GetKey (KeyCode.D)) {
			mueve_derecha ();
		}
		Vector2 vel = GetComponent<Rigidbody2D>().velocity;
		Debug.DrawLine(transform.position, new Vector3 (transform.position.x + vel.x, transform.position.y + vel.y, transform.position.z));
	}

	/*
	 * 
	 */

	void salto(){
		Debug.Log("Salta!!");
		rg.AddForce(new Vector2(0,fuerza));
	}

	void mueve_derecha(){
		transform.localScale = mira_derecha;
		Debug.Log("Derecha!!");
		rg.AddForce(new Vector2(velocidad_pollo,0));
	}

	void mueve_izquierda(){
		transform.localScale = mira_izquierda;
		Debug.Log("Izquierda!!");
		rg.AddForce(new Vector2(-velocidad_pollo,0));

	}
}
