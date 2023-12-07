using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
   }
   
   //Función en la que sucederá algo cuando la bala toque a alguien
   private void OnTriggerEnter2D(Collider2D collision){
   	if(collision.gameObject.tag == "Enemy"){
   	//Los mata muajaja y destruye la bala
   	   Destroy(collision.gameObject);
   	   Destroy(gameObject);
   	}
   	//Para que las intancias de las balas se destruyan y no se coman a memoria 
   	if(collision.gameObject.tag == "Boundary"){
   	   Destroy(gameObject);
   	}
   }
}
