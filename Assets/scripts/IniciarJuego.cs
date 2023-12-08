using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Clase que se encarga de iniciar el juego

public class IniciarJuego : MonoBehaviour
{
    // Start is called before the first frame update
    public void Iniciar()
    {
        SceneManager.LoadScene(2);
    }
}
