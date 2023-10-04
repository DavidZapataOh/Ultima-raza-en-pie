using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class ControlJuego : MonoBehaviour
{
    public void OnJugar()
    {
        MMSceneLoadingManager.LoadScene("Nivel1");
        Debug.Log("Ir a jugar");
    }
    public void OnCreditos()
    {
        MMSceneLoadingManager.LoadScene("Creditos");
        Debug.Log("Ir a creditos");
    }

    public void OnInstrucciones()
    {
        MMSceneLoadingManager.LoadScene("Instrucciones");
        Debug.Log("Ir a instrucciones");
    }

    public void OnHome()
    {
        MMSceneLoadingManager.LoadScene("Home");
        Debug.Log("Ir a Home");
    }

}
