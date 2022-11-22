using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GCLogicCreditos : MonoBehaviour
{
    [Header("Coldown para pasar de escena")]
    [SerializeField] private float coldownEscena;


    //variables privadas
    private float tiempoActualEscena;

    private void Start()
    {
        tiempoActualEscena = 0f;
    }
    private void Update()
    {
        PasarEscena();
    }

    private void PasarEscena()
    {
        if (tiempoActualEscena > coldownEscena)
        {
            //print("Se cambia de escena");
            tiempoActualEscena = 0f;
            SceneManager.LoadScene(0);

        }
        tiempoActualEscena += Time.deltaTime;
    }
}
