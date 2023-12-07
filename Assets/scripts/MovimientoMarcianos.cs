using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMarcianos : MonoBehaviour
{
	public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        //MOver la nave	
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
    //FUnción que hace que cuando los marcianos tocan una barrera se muevan para abajo
    private void OnTriggerEnter2D(Collider2D collision)
    {//Cada vez que toque una barrera realizará lo que está dentro del cuerpo de la función
    //Collision es a lo que pegan los marcianos
    
    	if(collision.gameObject.tag == "Boundary"){
    	  //Cuando peguen con una barrera se moverán a la dirección contraria
    	  transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
    	  moveSpeed *= -1;
    	  
    	}
    	
    }
}
