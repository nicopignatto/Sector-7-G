using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlEscenas : MonoBehaviour
{
    public void CambiarScena(string n){
        SceneManager.LoadScene(n);
    }

    public void IrMenu(){
        SceneManager.LoadScene("Menu");
    }
    
    [ContextMenu("Reiniciar")]
    public void Reiniciar(){
        //Debug.Log(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Salir(){
        Application.Quit();
    }

    public void PruebaScene(string n){
        Debug.Log("La escena "+n);
    }
}
