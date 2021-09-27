using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float velocidadeY;
    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody.velocity = new Vector2(0, this.velocidadeY);
    }

    // FUNÇÃO VALIDANDO COLISÃO DO LASER E DO INIMIGO
    public void OnTriggerEnter2D(Collider2D collider) {
        if (collider.CompareTag("Inimigo")) {
            
            
            Enemy inimigo = collider.GetComponent<Enemy>();
            inimigo.Destruir();
            // DESTROI O PROPRIO LASER
            Destroy(this.gameObject);
        }
    }

}
