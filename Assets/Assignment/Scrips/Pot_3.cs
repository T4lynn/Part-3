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
                    sr.sprite = sprites[2];
                    previouscase = 2;
                }
                break;
            case 3:
                if (previouscase == 2)
                {
                    Debug.Log("watered");
                    sr.sprite = sprites[3];
                    StateTracker.pot3states = 4;
                    previouscase = 3;
                }
                break;
            case 4:
                if (previouscase == 3)
                {
                    Debug.Log("growing");
                    sr.sprite = sprites[4];
                    previouscase = 4;
                }
                break;
        }
    }
       
}
