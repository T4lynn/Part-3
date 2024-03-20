using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerprefab;
    public Transform spawnpoint;
    public Transform spawnpoint2;
    public float dashspeed = 7;
    public float dashtime = 2;
    public override ChestType canOpen()
    {
        return ChestType.Thief;
    }
    protected override void Attack()
    {
        StartCoroutine(dash());
    }
    //protected override void Update()
    //{
    //    base.Update();
    //  if(isdashing)
    //    {
    //        dash();
    //    }
    //}
    IEnumerator dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 7;
        while (speed > 3)
        {
            yield return null;
        }
        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerprefab, spawnpoint.position, spawnpoint.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(daggerprefab, spawnpoint2.position, spawnpoint2.rotation);
    }

    public override string ToString()
    {
        return "hi, im bob";

    }
}
