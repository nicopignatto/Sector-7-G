using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botones_m1 : MonoBehaviour
{
    [SerializeField] private Color idle;
    [SerializeField] private Color Scolor;
    [SerializeField] private float time;
    [SerializeField] private string[] Secuencia;
    private string resp;
    private int indexS;
    private int index;

    //[SerializeField] private Image[] Botones;
    private int indexColor;

    private void Awake(){
        //Botones= new Image[transform.childCount];
        //for(int i=0; i<transform.childCount; i++){
            //Botones[i]= transform.GetChild(i).GetComponent<Image>();
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        resp= "";
        indexS= 0;
        indexColor=0;
        index= 0;
        /*for(int i=0; i<Botones.Length; i++){
            Botones[i].color= idle;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CombBotones(string n){
        char c=n[0];
        if(c==resp[index]){
            index++;
            if(index >= resp.Length){
                indexS++;
                index= 0;
                if(indexS >= Secuencia.Length){
                    indexS= 0;
                }
                SigSecuencia();
            }
        }else index=0;
    }
    
    public void SigSecuencia(){
        resp= Secuencia[indexS];
        indexColor=0;
        MostrarSecuencia();
    }

    public void MostrarSecuencia(){
        if(indexColor < resp.Length){
            int m= resp[indexColor] -'0';
            m--;
            if(m < transform.childCount && m >= 0){
                Image img = transform.GetChild(m).GetComponent<Image>();
                img.color= Scolor;
                Debug.Log("a "+m);
                Tareas.Nueva(time, PintarBoton);
            }
        }
    }
    public void PintarBoton(){
        if(indexColor < resp.Length){
            int m= resp[indexColor] - '0';
            m--;
            if(m < transform.childCount && m >= 0){
                Image img = transform.GetChild(m).GetComponent<Image>();
                img.color= Scolor;
                Debug.Log("b "+m);
                indexColor++;
                MostrarSecuencia();
            }
        }
    }
}