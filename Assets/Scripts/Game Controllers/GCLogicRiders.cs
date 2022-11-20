using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GCLogicRiders : MonoBehaviour
{
    [Header("Vel. de fuerza de elevación del Slider")]
    [SerializeField] private float velElevacionSlider;

    [Header("Rangos del Rider 1")]
    [SerializeField] private float minRangoRider1;
    [SerializeField] private float maxRangoRider1;

    [Header("Rangos del Rider 2")]
    [SerializeField] private float minRangoRider2;
    [SerializeField] private float maxRangoRider2;

    [Header("Rangos del Rider 3")]
    [SerializeField] private float minRangoRider3;
    [SerializeField] private float maxRangoRider3;

    [Header("Linkeos")]
    [SerializeField] private Slider rider1;
    [SerializeField] private Slider rider2;
    [SerializeField] private Slider rider3;
    [SerializeField] private Animator animatorAgujaMedidor1;
    [SerializeField] private Animator animatorAgujaMedidor2;
    [SerializeField] private Animator animatorAgujaMedidor3;
    /*[SerializeField] private AudioSource audioSourceMedidor1;
    [SerializeField] private AudioSource audioSourceMedidor2;
    [SerializeField] private AudioSource audioSourceMedidor3;*/

    //variables privadas
    private bool sePuedeMoverElSlider1;
    private bool sePuedeMoverElSlider2;
    private bool sePuedeMoverElSlider3;

    private void Start()
    {
        sePuedeMoverElSlider1 = true;
        sePuedeMoverElSlider2 = true;
        sePuedeMoverElSlider3 = true;
        //audioSourceMedidor1.Stop();
    }
    private void Update()
    {
        MovSliders();
    }

    private void MovSliders()
    {
        if (sePuedeMoverElSlider1)
        {
            rider1.value += velElevacionSlider;
        }

        if (sePuedeMoverElSlider2)
        {
            rider2.value += velElevacionSlider;
        }

        if (sePuedeMoverElSlider3)
        {
            rider3.value += velElevacionSlider;
        }

        if (rider1.value > minRangoRider1 && rider1.value < maxRangoRider1)
        {
            sePuedeMoverElSlider1 = false;
            //print("El slider 1 se para");
            //animatorAgujaMedidor1.StopPlayback();
            //print("Se detiene la aguja 1");
            animatorAgujaMedidor1.enabled = false;
            //audioSourceMedidor1.Play();
        }
        else
        {
            sePuedeMoverElSlider1 = true;
            //print("El slider 1 se vuelve a mover");
            //print("La aguja 1 continua moviendose");
            animatorAgujaMedidor1.enabled = true;
            //audioSourceMedidor1.Stop();
        }

        if (rider2.value > minRangoRider2 && rider2.value < maxRangoRider2)
        {
            sePuedeMoverElSlider2 = false;
            animatorAgujaMedidor2.enabled = false;
        }
        else
        {
            sePuedeMoverElSlider2 = true;
            animatorAgujaMedidor2.enabled = true;
        }

        if (rider3.value > minRangoRider3 && rider3.value < maxRangoRider3)
        {
            sePuedeMoverElSlider3 = false;
            animatorAgujaMedidor3.enabled = false;
        }
        else
        {
            sePuedeMoverElSlider3 = true;
            animatorAgujaMedidor3.enabled = true;
        }
    }
}