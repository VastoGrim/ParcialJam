using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    ///la velocidad a la que el jugador se va a mover
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ///se crea un vector y se le pone nombre, declaramos que las variables del vector son el input horizontal y vertical, y 0 en Z).
        Vector3 mov = new Vector3(
           Input.GetAxisRaw("Horizontal"),
           Input.GetAxisRaw("Vertical"),
           0
           );

        ///le estamos diciendo que debe de seguir las coordenadas del vector desde la posición en la que se encuentra (el transform),
        ///se le suma el input del player al transform relativo al float que pusimos sobre segundos.
        transform.position = Vector3.MoveTowards(
            transform.position,
            transform.position + mov,
            speed * Time.deltaTime);

    }

    
}
