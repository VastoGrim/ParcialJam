using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
   
    public GameObject spawnPoint;
    public GameObject ExplosionPrefab;
    public GameObject projectilePrefab;
    public float speed;
   
 

    
   
    // Update is called once per frame
    void Update () {
       
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D hitPlayerRB;
            GameObject hitPlayer;
            hitPlayer = Instantiate(projectilePrefab, transform.position, transform.rotation) as GameObject;
            hitPlayerRB = hitPlayer.GetComponent<Rigidbody2D>();
            hitPlayerRB.velocity = new Vector2(speed, 0);

            //            Physics.IgnoreCollision ( projectilePrefab.collider, transform.root.collider );


        }
 
   
        for(var i =0; i < Input.touchCount; ++i)
        {
            if(Input.GetTouch(i).phase == TouchPhase.Began )
            {
            GameObject clone;
            Rigidbody2D cloneRB;
            clone = Instantiate(projectilePrefab, transform.position, transform.rotation) as GameObject;
                cloneRB = clone.GetComponent<Rigidbody2D>();
                cloneRB.velocity = new Vector2(speed, 0);
                //            Physics.IgnoreCollision ( projectilePrefab.collider, transform.root.collider );


            }
        }
       
       
       
    }
}