using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    private float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision){
   	if(collision.gameObject.tag == "Player"){
   	//Se elimina una bala
   	   Destroy(gameObject);
       print("Player hit");
   	}
   	//Para que las intancias de las balas se destruyan y no se coman a memoria 
   	if(collision.gameObject.tag == "Boundary"){
   	   Destroy(gameObject);
   	}
    if(collision.gameObject.tag == "Enemy"){
    }
    }
}
