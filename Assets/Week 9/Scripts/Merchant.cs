using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Merchant : Villager
{
    public override ChestType canOpen()
    {
        return ChestType.Merchant;
    }
}
