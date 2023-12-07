using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{	
	public float moveSpeed = 5; 
	public float hInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	//Para presionar los botones, son como las entradas
    	hInput = Input.GetAxisRaw("Horizontal");
        //MOver la nave	
        transform.Translate(Vector2.right * hInput * moveSpeed * Time.deltaTime);
        //Delta es decir que se mueva de acuerdo al tiempo
    }
}
