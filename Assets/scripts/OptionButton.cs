using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Clase que se encarga de pasra a las opciones.

public class OptionButton : MonoBehaviour
{
    // Start is called before the first frame update
   public void toOptions()
    {
        SceneManager.LoadScene(1);
    }
}
