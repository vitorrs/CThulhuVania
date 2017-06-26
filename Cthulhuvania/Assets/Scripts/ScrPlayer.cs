using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour {

    bool colisao;
    public Rigidbody2D rb;
	public Animator Animacao;
	public float jumpForce;
    public float MV;
	private float MVAtual;
    public bool botaoDireitoPrecionado;
    public bool botaoEsquerdoPrecionado;

    // Use this for initialization
    void Start() {
        botaoDireitoPrecionado = false;
        botaoEsquerdoPrecionado = false;
        MVAtual= 0;
        rb = GetComponent<Rigidbody2D>();
		Animacao = GetComponent <Animator>();
        colisao = false;
    }

    // Update is called once per frame
    void Update() {
		Animacao.SetBool ("d", false);
		Animacao.SetBool ("a", false);
        if (Input.GetButton("Esquerda") && botaoDireitoPrecionado == false) {
            botaoEsquerdoPrecionado = true;
            MVAtual = -MV;
			rb.transform.localScale = new Vector2(-1,1);
			Animacao.SetBool ("a", true);
        }
        else if (Input.GetButtonUp("Esquerda") && botaoEsquerdoPrecionado == true){
            botaoEsquerdoPrecionado = false;
            MVAtual = 0;
        }
        if (Input.GetButton("Direita") && botaoEsquerdoPrecionado == false){
            botaoDireitoPrecionado = true;
			MVAtual = MV;
			rb.transform.localScale = new Vector2(1,1);
			Animacao.SetBool ("d", true);
        }
        else if (Input.GetButtonUp ("Direita") && botaoDireitoPrecionado == true){
            botaoDireitoPrecionado = false;
            MVAtual = 0;
        }
		if (Input.GetKeyDown(KeyCode.W) && colisao == true){
			rb.AddForce(transform.up * jumpForce);
            colisao = false;
		}
        rb.velocity = new Vector3(MVAtual * Time.deltaTime , 0 , 0);
    }

    void OnCollisionEnter2D(Collision2D collision){
        Vector2 normal = collision.contacts[0].normal;
        if (normal == Vector2.up)
        {
            colisao = true;
        }
    }
}

