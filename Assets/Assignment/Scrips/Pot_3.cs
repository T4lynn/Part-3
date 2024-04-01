using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pot_3 : Pot
{
   
    protected override void thisevent()
    {
        switch (StateTracker.pot3states)
        {
            case 0:
                sr.sprite = sprites[0];
                break;
            case 1:
                if (previouscase == 0)
                {
                    Debug.Log("filled with dirt");
                    sr.sprite = sprites[1];
                    previouscase = 1;
                }
                break;
            case 2:
                if (previouscase == 1)
                {
                    Debug.Log("planted seeds");
                    sr.sprite = sprites[3];
                    previouscase = 2;
                }
                break;
            case 3:
                if (previouscase == 2)
                {
                    Debug.Log("watered");
                    sr.sprite = sprites[2];
                    previouscase = 3;
                    StartCoroutine("growplants");
                }
                break;
        }
    }
       
}
