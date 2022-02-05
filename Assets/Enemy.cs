using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float health = 200f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageDealer damDeal = collision.gameObject.GetComponent<DamageDealer>();
        if (!damDeal) { return; }
        ProcessHit(damDeal);
    }

    private void ProcessHit(DamageDealer damDeal)
    {
        health -= damDeal.GetDamage();
        damDeal.Hit();

        if(health<=0)
        {
            Destroy(gameObject);
        }

    }
}
