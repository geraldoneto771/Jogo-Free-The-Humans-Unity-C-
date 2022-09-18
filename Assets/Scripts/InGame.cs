using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame : MonoBehaviour
{
    //criando variavel para controlar o texto de pontua��o
    public Text textoPontuacao;
    public BarraVida barraVida;
    
    private NavePlayer jogador;

    private void Start(){
        this.jogador = GameObject.FindGameObjectWithTag("Player").GetComponent<NavePlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        this.barraVida.ExibirVida(this.jogador.Vida);
        //pegando a variavel pontuacao do script PointControler e armazenando na variavel textoPontuacao
        this.textoPontuacao.text = PointController.pontuacao + "x ";
    }
}
