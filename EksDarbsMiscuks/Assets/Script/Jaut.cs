﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Jaut : MonoBehaviour {
    public GameObject Nakamais;
    public GameObject paraditAtbPoga;
    public GameObject[] Jautajumi = new GameObject[9];//9
    private int a = 0;
    public Toggle[]  toggle;//= new GameObject[7];//7 potomu 4to 4 toogle potom na 40 nado 
    int[] kluda = { 0,0,0,0,0,0,0,0,0,0 };
    public GameObject Teksts;
   private float pareizas = 0;

    //1
    public void ParbJautA()
        {
        
        
        if (toggle[0].isOn)
        {
            kluda[0] = 1;
        }
        
        if (!toggle[1].isOn)
        {
              kluda[0] = 1;
        }

        if (toggle[2].isOn)
        {
              kluda[0] = 1;
        }
      
        if (!toggle[3].isOn)
        {
               kluda[0] = 1;
        }
      
       

        Debug.Log("odin" + kluda[0]);
    }
    //2
    public void ParbJautB()
    {
        if (!toggle[4].isOn)
        {
            kluda[1] = 1;
        }
        if (!toggle[5].isOn)
        {
            kluda[1] = 1;
        }
        if (!toggle[6].isOn)
        {
            kluda[1] = 1;
        }
        if (toggle[7].isOn)
        {
            kluda[1] = 1;
        }
        Debug.Log("dva"  + kluda[1]);

    }
    //3
    public void ParbJautC()
    {
        if (!toggle[8].isOn)
        {
            kluda[2] = 1;
        }
        if (!toggle[9].isOn)
        {
            kluda[2] = 1;
        }
        if (toggle[10].isOn)
        {
            kluda[2] = 1;
        }
        if (toggle[11].isOn)
        {
            kluda[2] = 1;
        }
        Debug.Log("tri" + kluda[2]);
    }
    //4
    public void ParbJautD()
    {
        if (!toggle[12].isOn)
        {
            kluda[3] = 1;
        }
        if (toggle[13].isOn)
        {
            kluda[3] = 1;
        }
        if (toggle[14].isOn)
        {
            kluda[3] = 1;
        }
        if (!toggle[15].isOn)
        {
            kluda[3] = 1;
        }
        Debug.Log("four" + kluda[3]);
    }
    //5
    public void ParbJautE()
    {
        if (!toggle[16].isOn)
        {
            kluda[4] = 1;
        }
        if (toggle[17].isOn)
        {
            kluda[4] = 1;
        }
        if (!toggle[18].isOn)
        {
            kluda[4] = 1;
        }
        if (toggle[19].isOn)
        {
            kluda[4] = 1;
        }
    }
    //6
    public void ParbJautF()
    {
        if (toggle[20].isOn)
        {
            kluda[5] = 1;
        }
        if (!toggle[21].isOn)
        {
            kluda[5] = 1;
        }
        if (!toggle[22].isOn)
        {
            kluda[5] = 1;
        }
        if (toggle[23].isOn)
        {
            kluda[5] = 1;
        }
    }
    //7
    public void ParbJautG()
    {
        if (!toggle[24].isOn)
        {
            kluda[6] = 1;
        }
        if (toggle[25].isOn)
        {
            kluda[6] = 1;
        }
        if (!toggle[26].isOn)
        {
            kluda[6] = 1;
        }
        if (toggle[27].isOn)
        {
            kluda[6] = 1;
        }
    }
    //8
    public void ParbJautH()
    {
        if (toggle[28].isOn)
        {
            kluda[7] = 1;
        }
        if (!toggle[29].isOn)
        {
            kluda[7] = 1;
        }
        if (toggle[30].isOn)
        {
            kluda[7] = 1;
        }
        if (!toggle[31].isOn)
        {
            kluda[7] = 1;
        }
    }
    //9
    public void ParbJautI()
    {
        if (!toggle[32].isOn)
        {
            kluda[8] = 1;
        }
        if (toggle[33].isOn)
        {
            kluda[8] = 1;
        }
        if (!toggle[34].isOn)
        {
            kluda[8] = 1;
        }
        if (toggle[35].isOn)
        {
            kluda[8] = 1;
        }
    }
    //10
    public void ParbJautJ()
    {
        if (!toggle[36].isOn)
        {
            kluda[9] = 1;
        }
        if (!toggle[37].isOn)
        {
            kluda[9] = 1;
        }
        if (toggle[38].isOn)
        {
            kluda[9] = 1;
        }
        if (toggle[39].isOn)
        {
            kluda[9] = 1;
        }
    }
    public void Paradit()
    {
        if (a == 0)
        {
            ParbJautA();
        } else if (a == 1)

        {
            ParbJautB();
        } else if (a == 2)
        {
            ParbJautC();
        } else if (a == 3)
        {
            ParbJautD();
        } else if (a == 4)
        {
            ParbJautE();
        } else if (a == 5)
        {
            ParbJautF();
        } else if (a == 6) {

            ParbJautG();
        }
        else if (a == 7)
        {
            ParbJautH();
        }
        else if (a == 8)
        {
            ParbJautI();
        }
        else if (a == 9)
        {
            ParbJautJ();
        }
      



            Jautajumi[a].SetActive(false);
      
        a++;
        
        if (a == 10)//a>=10
        {
            a =10;//a=9
            Nakamais.SetActive(false);
            paraditAtbPoga.SetActive(true);
        }
        else
        {
         
            Jautajumi[a].SetActive(true);
        }
    }
	void Start()
	{

        Jautajumi[0].SetActive(true);
   }

    public void papa()
    {
  
    }

    public void ParadaitPareizus()
    {
       
        
        for (int j = 0; j <kluda.Length; j++)
        {

            if (kluda[j] == 0)
            {
                 pareizas++;
            }
         
            
      }
        //Debug.Log("Pareizzi2 " + pareizas);
        Teksts.GetComponent<Text>().text = pareizas + "/10"  ;
        Teksts.SetActive(true);
          paraditAtbPoga.SetActive(false);
        
    }

    public void ParaditKludas()
    {

        if (kluda[0] == 0)
        {

        }
        else if (kluda[1] == 0)
        {

        }
        else if (kluda[3] == 0)
        {

        }
        else if (kluda[4] == 0)
        {
        
        }


        }
   

}
