using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroid : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public float velocidadeMaxima = 1.0f;
    void Start()
    {
       Vector2 direcao = Random.insideUnitCircle;
        meuRigidbody.velocity = direcao;
    }

    
    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
        Destroy(outro.gameObject);
    }
}
