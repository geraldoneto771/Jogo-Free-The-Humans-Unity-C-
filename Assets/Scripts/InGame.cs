using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame : MonoBehaviour
{
    //criando variavel para controlar o texto de pontua��o
    public Text textoPontuacao;
    

    // Update is called once per frame
    void Update()
    {
        //pegando a variavel pontua��o do script PointControler e armazenando na variavel textoPontua��o
        this.textoPontuacao.text = PointController.pontuacao + "x ";
    }
}
