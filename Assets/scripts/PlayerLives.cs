using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLives : MonoBehaviour
{
	public int lives = 3;
	private int vidasP= 0;
	public Image[] livesUI;
	public GameObject parent;
	public AudioSource hitsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
    	if(collision.collider.gameObject.tag == "Enemy"){
    		Destroy(collision.gameObject);
			hitsound.Play();
			lives -=1; 
			parent.transform.GetChild(vidasP).gameObject.SetActive(false);
			vidasP+=1;
			for(int i = 0;i<livesUI.Length;i++){
    			if(i<lives){
    			
    				livesUI[i].enabled = true;
    			}else{
    				livesUI[i].enabled = false;
    			}
    		}
    		if(lives<=0){
    			Destroy(gameObject); //Destruye el objeto en colisión
				SceneManager.LoadScene(3);
    		}
    	
    	}
    }
}
