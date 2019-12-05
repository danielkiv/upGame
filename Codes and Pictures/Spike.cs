//script for the object to damage the player's health
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    public int Damage = 20;

    //when the player collide with the object, damage the player by the damage amount
    void OnCollisionEnter2D(Collision2D info)
    {
        Player player = info.collider.GetComponent<Player>();

        if(player != null)
        {
            player.DamageHealth(Damage);
        }
    }
}
