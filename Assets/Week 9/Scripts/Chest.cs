using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ChestType { villager, Merchant, Archer, Thief }

public class Chest : MonoBehaviour
{
    public Animator animator;
    public ChestType whocanopen;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Villager>(out Villager villager))
        {
            if(villager.canOpen() == whocanopen || whocanopen == ChestType.villager)
            {
                animator.SetBool("IsOpened", true);
            }
        }
     
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("IsOpened", false);
    }
}
