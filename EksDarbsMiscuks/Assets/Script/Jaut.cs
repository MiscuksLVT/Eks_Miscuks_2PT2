using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Jaut : MonoBehaviour {
    public GameObject Nakamais;
    public GameObject paraditAtbPoga;
    public GameObject[] Jautajumi = new GameObject[3];//9
    private int a = 0;
    public Toggle[]  toggle;//= new GameObject[7];//7 potomu 4to 4 toogle potom na 40 nado 
    int[] kluda = { 0,0,0,0 };
    public GameObject Teksts;
   private float pareizas = 0;
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





    public void Paradit()
    {
        if (a == 0)
        {
            ParbJautA();
        }else if (a == 1)

        {
            ParbJautB();
      }else if(a==2)
        {
            ParbJautC();
        } else if (a == 3)
        {
            ParbJautD();
        }



        Jautajumi[a].SetActive(false);
      
        a++;
        
        if (a == 4)//a>=10
        {
            a = 4;//a=9
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
        int num = 0;
        bool ir = false;

        for (int j = 0; j <kluda.Length; j++)
        {

            if (kluda[j] == 1)
            {
               
            }
            else
            {
                ir = true;
            }
            
            if (ir)
            {

              
                
                pareizas++;
                papa();
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
