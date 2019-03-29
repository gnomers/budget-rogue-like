using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour            //skapar public klassen Level system(Mono behaviour=unity script)
{
    public int XP;                                  //skapar en variabel XP och säger att den ska inehåla heltal
    public int currentLevel;                        //skapar en variabel currentlevel
        
    
    // Update is called once per frame
    void Update()                                   //kör scriptet och släng allt som kommer tillbacka
    {
if  (false)                                         //just nu Om inte stämmer kör
        UpdateXp(5);                            
    }

    public void UpdateXp(int xp)                   //skapar en variabel (updateXp) som alla kan kalla på
    {
        XP  += xp;                                 //säger att XP=XP+xp

        int curlvl = (int)(0.1f * Mathf.Sqrt(XP));  //heltalet curlvl = 0,1* roten ur XP

        if(curlvl != currentLevel)                  //om curlvl inte = currentlevel 
        {
            currentLevel = curlvl;                  //så är currentlevel = curlvl
            //level text
        } 

        int xpnextlevel = 100 * (currentLevel +1) * (currentLevel + 1);     //heltalet xpnextlevel = 100 * din level + 1 * din level + 1
        int differencexp = xpnextlevel - xp;                                //heltalet differencexp = all xp från 0 - nästa level - xpn till nästa level

        int totaldifference = xpnextlevel -(100 * currentLevel * currentLevel);     //heltalet totaldifference = xp till nästa level -(100 * din level just nu * din level just nu)
    }   
}


