using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StateTracker : MonoBehaviour
{
    public static int pot1states;
    public static int pot2states;
    public static int pot3states;

    private void Start()
    {
        pot3states = 0;
        pot2states = 0;
        pot1states = 0;


    }

    public void swapstate(int state)
    {
        pot1states = state;
        pot2states = state;
        pot3states = state;
    }
}
