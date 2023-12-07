using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShoot : MonoBehaviour
{
//Referencia al prefab
	public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {	
    //EL fire1 se refiere al botón de disparo, duh
        if(Input.GetButtonDown("Fire1")){
        //Cada vez que presionas el botón de fire se instancia una bala en el juego
             Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        //Primero lo que instancias, dónde lo spawneas, para no rotarlo
        }
    }
}
