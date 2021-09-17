using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InterfacePontuacao : MonoBehaviour
{
       public TMP_Text textoPontuacao;
       public int pontuacao;

        void Awake()
        {
           textoPontuacao.text = "";

           ComportamentoAsteroid.EventoAsteroidDestruido += AsteroidFoiDestruido;
        }
        void OnDestroy()
        {
            ComportamentoAsteroid.EventoAsteroidDestruido -= AsteroidFoiDestruido;
        }
        void AsteroidFoiDestruido()
        {
           pontuacao += 10; 
           AtualizaTextoPontuacao();
        }
        void AtualizaTextoPontuacao()
        {
            
           textoPontuacao.text = pontuacao.ToString();

        }
       
}
