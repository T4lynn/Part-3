using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDemo : MonoBehaviour
{
    public SpriteRenderer sr;
    public Color start;
    public Color end;
    float interpol;
    public TMP_Dropdown dd;

    public void Update()
    {
        sr.color = Color.Lerp(start, end, (interpol/60));
    }
    public void slidervaluechanged(Single value)
    {
       interpol = value;
    }

    public void dropdownchanged(Int32 value)
    {
        Debug.Log(dd.options[value].text);
    }
}
