using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraGameplay : MonoBehaviour
{
   public static CameraGameplay instancia; 
   public Camera minhaCamera;

   void Awake()
   {
       instancia = this;
   }

}
