using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders_m2 : MonoBehaviour
{
    [SerializeField] private Slider sld;
    [SerializeField]private GameObject guja;
    public float valor;
    // Start is called before the first frame update
    void Start()
    {
        valor=0;
    }

    // Update is called once per frame
    void Update()
    {
        guja.transform.eulerAngles= new Vector3(0,0,valor);   
    }

    public void MovSliders(float value){
        guja.transform.eulerAngles= new Vector3(0,0,-value*2);
        guja.transform.eulerAngles= new Vector3(0,0,-sld.value*2); 
    }
}
