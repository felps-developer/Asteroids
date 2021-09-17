using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoAsteroid : MonoBehaviour
{
    public static System.Action EventoAsteroidDestruido = null;

    public Rigidbody2D meuRigidbody;
    public ComportamentoAsteroid prefabAsteroidMenor;
    public float velocidadeMaxima = 1.0f;
    public int qtdAsteroide = 3;
    void Start()
    {
       Vector2 direcao = Random.insideUnitCircle;
        meuRigidbody.velocity = direcao;
    }

    
    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
        Destroy(outro.gameObject);
        for (int i=0; i < qtdAsteroide; i++)
        {

            Instantiate(prefabAsteroidMenor,
            meuRigidbody.position,
            Quaternion.identity);

        }
        if(EventoAsteroidDestruido != null)
        {
            EventoAsteroidDestruido();
        }
    }
    
}
