using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Aqui asignamos el objeto que será el player
    public Transform player;
    //El rango en el que el enemigo empezara a buscar al player.
    public float walkingDistance = 10.0f;
    //El tiempo que el enemigo se va a tardar en llegar al player
    public float smoothTime = 10.0f;
    //Vector3 que se usa para guardar la velocidad del enemigo
    private Vector3 smoothVelocity = Vector3.zero;
    //Call every frame
    void Update()
    {
        
        //calcula la distancia entre el jugador y el enemigo
        float distance = Vector3.Distance(transform.position, player.position);
        //checa que la distancia sea menor que el rango
        if (distance < walkingDistance)
        {
            //se mueve hacia el player con smoothDamp
            transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, smoothTime);
        }
    }

}
