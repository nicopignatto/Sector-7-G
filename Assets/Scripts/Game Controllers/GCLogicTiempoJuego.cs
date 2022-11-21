using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GCLogicTiempoJuego : MonoBehaviour
{
    [Header("Cant. que se le resta al tiempo")]
    [SerializeField] private float cantRestaTiempo;

    [Header("Cant. que se le suma al tiempo")]
    [SerializeField] private float cantSumaTiempo;

    [Header("Linkeos")]
    [SerializeField] private Slider sliderTiempoJuego;

    //variables privadas 
    static private bool restoTiempoPorRestar;
    static private bool sumoTiempoPorAcierto;
    //static private bool restoTiempoPorError;

    /*static public bool RestoTiempoPorError
    {
        get
        {
            return restoTiempoPorError;
        }
        set
        {
            restoTiempoPorError = value;
        }
    }*/

    static public bool RestoTiempoPorRestar
    {
        get
        {
            return restoTiempoPorRestar;
        }

        set
        {
            restoTiempoPorRestar = value;
        }
    }

    static public bool SumoTiempoPorAcierto
    {
        get
        {
            return sumoTiempoPorAcierto;
        }

        set
        {
            sumoTiempoPorAcierto = value;
        }
    }

    private void Start()
    {
        //restoTiempoPorError = false;
        restoTiempoPorRestar = true;
        sumoTiempoPorAcierto = false;
    }

    private void Update()
    {
        RestaTiempoJuego();
        SumaTiempoJuego();
        PasoDeEscena();
    }

    private void RestaTiempoJuego()
    {
        if (restoTiempoPorRestar)
        {
            sliderTiempoJuego.value -= cantRestaTiempo * 0.5f;
        }

        /*if (restoTiempoPorError)
        {
            sliderTiempoJuego.value -= cantRestaTiempo * 2f;
        }
        else
        {
            sliderTiempoJuego.value -= cantRestaTiempo;
        }*/
    }

    private void SumaTiempoJuego()
    {
        if (sumoTiempoPorAcierto)
        {
            sliderTiempoJuego.value += cantSumaTiempo;
        }
    }

    private void PasoDeEscena()
    {
        if (sliderTiempoJuego.value == 0f)
        {
            //Debug.Log("Se acabo el tiempo y se pasa a los créditos");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
