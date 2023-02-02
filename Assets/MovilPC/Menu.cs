using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void NewGameClick()
    {
        //Bot�n de iniciar juego, te manda a la escena del juego
        SceneManager.LoadScene("SampleScene");
    }
    public void CreditosClick()
    {
        //Bot�n de iniciar créditos, te manda a la escena de los créditos
        SceneManager.LoadScene("Creditos");
    }
    public void ExitClick()
    {
        //Bot�n para salir del juego
        Application.Quit();
    }

    public void MenuClick()
    {
        //Bot�n de iniciar créditos, te manda a la escena de los créditos
        SceneManager.LoadScene("Menu");
    }
}
