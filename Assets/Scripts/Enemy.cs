using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float velocidadeMin;
    public float velocidadeMax;

    private float velocidadeY;
    // Start is called before the first frame update
    void Start()
    {
        this.velocidadeY = Random.Range(this.velocidadeMin, velocidadeMax);
    }

    // Update is called once per frame
    void Update()
    {
        this.rigidbody.velocity = new Vector2(0,-this.velocidadeY);
    }

    public void Destruir(bool derrotado){
        if (derrotado)
        {
            PointController.Pontuacao++;
            
        }
        Destroy(this.gameObject);
    }
}
