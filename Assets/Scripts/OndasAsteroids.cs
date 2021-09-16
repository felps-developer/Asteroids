using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndasAsteroids : MonoBehaviour
{
    public ComportamentoAsteroid prefabsAsteroid;
    public int numeroAsteroid =3 ;
        void Start()
    {
        for(int i = 0; i< numeroAsteroid; i++)
        {
            float x = Random.Range(-10.5f,10.5f);
            float y = Random.Range(-5.5f,5.5f);
            Vector3 posicao = new Vector3(x,y,0.0f);
            Instantiate(prefabsAsteroid,posicao,Quaternion.identity);
        }
    }

    
    void Update()
    {
        
    }
}
