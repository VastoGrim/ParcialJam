using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //aquí ponemos que si colisiona con alguien con este tag
        if (collision.CompareTag("Skeleton"))
        {
            //lo destruye
            Destroy(collision.gameObject);
        }
    }
}
