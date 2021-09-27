using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//a classe não herderá de monobehaviur, será do tipo static pois não pode ser instanciada
public static class PointController 
{
    
    public static int pontuacao;

    public static int Pontuacao {
        // metodo para pegar o valor da pontuação
        get {
            return pontuacao;
        }
        // metodo para modificar o valor da pontuação
        set {
            pontuacao = value;
            //impedindo que valores negativos sejam atribuidos
            if (pontuacao < 0) {
                pontuacao = 0;
            }
            Debug.Log ("Pontuação: " + Pontuacao);
        }
    }
    
}
