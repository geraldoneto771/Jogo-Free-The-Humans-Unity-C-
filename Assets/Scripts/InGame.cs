using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGame : MonoBehaviour
{
    //criando variavel para controlar o texto de pontuação
    public Text textoPontuacao;
    

    // Update is called once per frame
    void Update()
    {
        //pegando a variavel pontuação do script PointControler e armazenando na variavel textoPontuação
        this.textoPontuacao.text = PointController.pontuacao + "x ";
    }
}
