using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Rigidbody2D PlayerBody;
	public Animator Animacao;
	float movesped = 2;


	void Start(){
		PlayerBody = GetComponent<Rigidbody2D> ();
		Animacao = GetComponent <Animator>();

	}
	// Update is called once per frame
	void FixedUpdate () {
		PlayerBody.velocity = new Vector2 (0, 0);
		Animacao.SetBool ("w", false);
		Animacao.SetBool ("d", false);
		Animacao.SetBool ("s", false);
		Animacao.SetBool ("a", false);

		if(Input.GetKey(KeyCode.D)){
			PlayerBody.velocity = new Vector2 (movesped, 0);
			Animacao.SetBool ("d", true);
			if (Input.GetKey (KeyCode.W)) {
				Animacao.SetBool ("w", true);
				Animacao.SetBool ("d", false);
			}
			if (Input.GetKey (KeyCode.S)) {
				Animacao.SetBool ("s", true);
				Animacao.SetBool ("d", false);
			}
		}


		else if(Input.GetKey(KeyCode.A)){
			PlayerBody.velocity = new Vector2 (-movesped, 0);
			Animacao.SetBool ("a", true);
			if (Input.GetKey (KeyCode.S)) {
				Animacao.SetBool ("s", true);
				Animacao.SetBool ("a", false);
			}
			if (Input.GetKey (KeyCode.W)) {
				Animacao.SetBool ("w", true);
				Animacao.SetBool ("a", false);
			}
		}


		else if(Input.GetKey(KeyCode.W)){
			PlayerBody.velocity = new Vector2 (0, movesped);
			Animacao.SetBool ("w", true);
			if (Input.GetKey (KeyCode.D)) {
				Animacao.SetBool ("d", true);
				Animacao.SetBool ("w", false);
			}
			if (Input.GetKey (KeyCode.A)) {
				Animacao.SetBool ("a", true);
				Animacao.SetBool ("w", false);
			}
		}


		else if(Input.GetKey(KeyCode.S)){
			PlayerBody.velocity = new Vector2 (0, -movesped);
			Animacao.SetBool ("s", true);
			if (Input.GetKey (KeyCode.D)) {
				Animacao.SetBool ("d", true);
				Animacao.SetBool ("s", false);
			}
			if (Input.GetKey (KeyCode.A)) {
				Animacao.SetBool ("a", true);
				Animacao.SetBool ("s", false);
			}
		}



		if(Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.D)){
			PlayerBody.velocity = new Vector2 (3*movesped/4, 3*movesped/4);
		}
		if(Input.GetKey(KeyCode.W)&&Input.GetKey(KeyCode.A)){
			PlayerBody.velocity = new Vector2 (-3*movesped/4, 3*movesped/4);
		}
		if(Input.GetKey(KeyCode.S)&&Input.GetKey(KeyCode.A)){
			PlayerBody.velocity = new Vector2 (-3*movesped/4, -3*movesped/4);
		}
		if(Input.GetKey(KeyCode.S)&&Input.GetKey(KeyCode.D)){
			PlayerBody.velocity = new Vector2 (3*movesped/4, -3*movesped/4);
		}
	}
}
