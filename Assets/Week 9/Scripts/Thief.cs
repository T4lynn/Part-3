using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerprefab;
    public Transform spawnpoint;
    public Transform spawnpoint2;
    public override ChestType canOpen()
    {
        return ChestType.Thief;
    }
    protected override void Attack()
    {
        base.Attack();
        Instantiate(daggerprefab, spawnpoint.position, spawnpoint.rotation);
        Instantiate(daggerprefab, spawnpoint2.position, spawnpoint2.rotation);
        dash();
    }
    void dash()
    {
        Vector2 direction =  destination - rb.position;
       Vector2 dashdist = direction.normalized * 2;
       rb.position = rb.position + dashdist;
        destination = rb.position;
        Debug.Log("dashed");
    }
}
