using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public GameObject[] barrasVermelhas;
    // Start is called before the first frame update
    public void ExibirVida(int vidas){
        for (int i = 0; i < this.barrasVermelhas.Length; i++){
            if (i < vidas){
                //ativar barras
                this.barrasVermelhas[i].SetActive(true);

            }else{
                //desativar barras
                this.barrasVermelhas[i].SetActive(false);
            }
        }
    }
}
