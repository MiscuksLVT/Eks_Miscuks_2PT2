using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class PareizasAtbildes : MonoBehaviour {


    public Toggle[] togglePareizas;
    public Toggle[] toggleNePareizi;
    public void ParadisanaPNAtb()
    {

        for (int i = 0; i <21; i++)
        {
            togglePareizas[i].GetComponentInChildren<Text>().color = new Color(0, 255, 00);
   
     }



        for (int i = 0; i < 19; i++)
        {

            toggleNePareizi[i].GetComponentInChildren<Text>().color = new Color(255, 0, 00);
        }



    }
}
