using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Villager
{
    public GameObject arrowprefab;
    public Transform spawnpoint;
    protected override void Attack()
    {
        destination = transform.position;
        base.Attack();  
        Instantiate(arrowprefab, spawnpoint.position, spawnpoint.rotation);
    }
}
