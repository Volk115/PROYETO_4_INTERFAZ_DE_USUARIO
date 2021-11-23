using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TARGET : MonoBehaviour
{
    private float timeDestroy = 2f;

    void Start()
    {
        //DESTRUYE EL OBJETO TRAS (2s)
        Destroy(gameObject, timeDestroy);
        

    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("GOOD"))
        {
            Destroy(gameObject);

            //DAR PUNTOS
            //SISTEMA DE PARTICULAS
            //MUSIQUITA DE ¡BIEN HECHO!


        }
        else if (gameObject.CompareTag("Bad"))
        {
            Destroy(gameObject);

            //GAMEOVER
            //RESTAR PUNTS
            //QUITAR VIDAS
            //MUSIQUITA DE GAMEOVER O MAS HECHO
            //SISTEMA DE PARTICULAS

        }



    }


}
