using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NavePlayer : MonoBehaviour
{
    //criando uma variavel do tipo rigidbody
    public Rigidbody2D rigidbody;
    //criando uma variavel para controlar a velocidade do player
    public float velocidadeMovimento;
    //criando variavel para controlar prefab do laser
    public Laser laserPrefab;
    //criando variavel privada para contar o tempo do laser
    private float intervaloTiro;
    //criando variavel para controlar tempo de espera do tiro
    public float tempoEsperaTiro;

    //criando variavel para controlar o transfrom da posicao da arma
    public Transform[] posicoesArmas;
    private Transform armaAtual;

    private int vidas;

    // Start is called before the first frame update
    void Start()
    {
        this.vidas = 5;
        this.intervaloTiro = 0;

        this.armaAtual = this.posicoesArmas[0];

        PointController.Pontuacao = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //atualizando o valor do intervalo do tiro
        this.intervaloTiro += Time.deltaTime;
        if (this.intervaloTiro >= this.tempoEsperaTiro) {
            this.intervaloTiro = 0;
            Atirar();
        }

        //Pegando o input das teclas seta direita e esquerda ou (a e d) e atribuindo a variavel float horizontal.
        float horizontal = Input.GetAxis("Horizontal");
        //Pegando o input das teclas seta cima e baixo ou (w e s) e atribuindo a variavel float vertical.
        float vertical = Input.GetAxis("Vertical");
        float velocidadeX = (horizontal * this.velocidadeMovimento);
        float velocidadeY = (vertical * this.velocidadeMovimento);
        //atribuindo os vetores (variaveis) velocidadeX e velocidadeY a velocidade do rigidbody
        this.rigidbody.velocity = new Vector2(velocidadeX, velocidadeY);



    }
    private void Atirar() {
        //criando uma instancia de um novo laser, na posicao da arma da nave e sem rotacionar
        Instantiate(this.laserPrefab, this.armaAtual.position, Quaternion.identity);
        if (this.armaAtual == this.posicoesArmas[0]) {
            this.armaAtual = this.posicoesArmas[1];

        } else {
            this.armaAtual = posicoesArmas[0];
        }
    }

    public int Vida
    {
        get
        {
            return this.vidas;
        }
        set
        {
            this.vidas = value;
            if(this.vidas <= 0)
            {
                this.vidas = 0;
                
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Inimigo"))
        {
            vidas--;
            Enemy inimigo = collider.GetComponent<Enemy>();
            inimigo.Destruir(false);
            Debug.Log(vidas);
        }
    }

}
