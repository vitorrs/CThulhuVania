using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour {

    public Rigidbody2D rb;
    public int velocidade;
    public bool botaoDireitoPrecionado;
    public bool botaoEsquerdoPrecionado;

    // Use this for initialization
    void Start() {
        botaoDireitoPrecionado = false;
        botaoEsquerdoPrecionado = false;
        velocidade = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButton("Esquerda") && botaoDireitoPrecionado == false) {
            botaoEsquerdoPrecionado = true;
            velocidade = -5;
        }
        else if (Input.GetButtonUp("Esquerda") && botaoEsquerdoPrecionado == true){
            botaoEsquerdoPrecionado = false;
            velocidade = 0;
        }
        if (Input.GetButton("Direita") && botaoEsquerdoPrecionado == false){
            botaoDireitoPrecionado = true;
            velocidade = 5;
        }
        else if (Input.GetButtonUp ("Direita") && botaoDireitoPrecionado == true){
            botaoDireitoPrecionado = false;
            velocidade = 0;
        }
        rb.velocity = new Vector3(velocidade * Time.deltaTime , 0, 0);
    }
}

