using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StateTracker : MonoBehaviour
{
    //this stores the values used in each pot's switchstatement
    public static int pot1states;
    public static int pot2states;
    public static int pot3states;

    private void Start()
    {
        //the values default to 0
        pot3states = 0;
        pot2states = 0;
        pot1states = 0;


    }

    //this function is used by the buttons.
    public void swapstate(int state)
    {
        pot1states = state;
        pot2states = state;
        pot3states = state;
    }
}
