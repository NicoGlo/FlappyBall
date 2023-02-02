using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void NewGameClick()
    {
        //Bot�n de iniciar juego, te manda a la escena del pantano
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitClick()
    {
        //Bot�n para salir del juego
        Application.Quit();
    }
}
