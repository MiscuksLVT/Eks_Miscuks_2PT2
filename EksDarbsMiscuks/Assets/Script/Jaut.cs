using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Jaut : MonoBehaviour {
    public GameObject Nakamais;
    public GameObject paraditAtbPoga;
    public GameObject[] Jautajumi = new GameObject[9];//9
    int a = 0;
    public GameObject[]  toggle;//= new GameObject[7];//7 potomu 4to 4 toogle potom na 40 nado 
    int[] papa ={ 0, 0, 0, 0, 0, 0,0 };
	
	  public void ParbJautA()
        {
        
        
        if (toggle[0])
        {
            papa[0] = 1;
        }
        else
        {
            papa[0] = 0;
        }
      //      if (toggle[1]  )
    // {
       //    papa[0] = 1;
      // }
     //   if (toggle[2] ==false)
    //    {
     //       papa[0] = 1;
   //     }
   //     if (toggle[3] ==false)
  //      {
   //         papa[0] = 1;
  //      }
        Debug.Log("odin" + papa[0]);
    }

    public void ParbJautB()
    {
        if (toggle[4] != true)
        {
            papa[1] = 1;
        }
        if (toggle[5] != false)
        {
            papa[1] = 1;
        }
        if (toggle[6] != true)
        {
            papa[1] = 1;
        }
        if (toggle[7] != false)
        {
            papa[1] = 1;
        }
        Debug.Log("dva"  + papa[1]);

    }
   public void Paradit()
    {
        if (a == 0)
        {
            ParbJautA();
        }else if (a == 1)

        {
            ParbJautB();
      // }



        Jautajumi[a].SetActive(false);
      
        a++;
        
        if (a >= 2)//a>=9
        {
            a = 2;//a=9
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

   

}
