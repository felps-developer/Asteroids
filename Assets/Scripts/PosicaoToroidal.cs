using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicaoToroidal : MonoBehaviour
{   
    const float Margem = 0.5f;

    public Rigidbody2D meuRigidbody;
    
    void Update()
    {
        Camera camera = CameraGameplay.instancia.minhaCamera;

        var maxX = camera.orthographicSize * camera.aspect;
        var maxy = camera.orthographicSize ;

        float LimiteEsquerda  = -maxX;
        float LimiteDireita  = maxX;
        float LimiteCima = maxy;
        float LimiteBaixo = -maxy;

        Vector2 pos = meuRigidbody.position;
        if(pos.x < LimiteEsquerda - Margem)
        {
            pos.x = LimiteDireita + Margem;
        }
        else if(pos.x > LimiteDireita + Margem)
        {
            pos.x = LimiteEsquerda - Margem;
        }
        if(pos.y < LimiteBaixo - Margem)
        {
            pos.y= LimiteCima + Margem;
        }
        else if(pos.y > LimiteCima + Margem)
        {
            pos.y = LimiteBaixo - Margem;
        }
        meuRigidbody.position = pos;
    }
}
