using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour
{
    public TMP_Text charactertext;
    public static string name1 = "none";
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        name1 = villager.name;
    }
    private void Start()
    {

        name1 = "None";
    }
    private void Update()
    {
        charactertext.text = name1;
    }
}
