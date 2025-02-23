﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    [SerializeField]
    private int hitPoints = 0;
    public int maxHitPoints = 2;
    private bool isPlayer;

    private void Start()
    {
        hitPoints = maxHitPoints;
        isPlayer = GetComponent<PlayerController>() != null;
    }

    public void TakeDamage(int damageAmount)
    {
        ModifyHitPoints(-1 * damageAmount);
    }

    public void HealDamage(int healAmount)
    {
        ModifyHitPoints(healAmount);
    }

    private void ModifyHitPoints(int modAmount)
    {
        hitPoints += modAmount;
        hitPoints = Mathf.Min(maxHitPoints, hitPoints);
        if (hitPoints <= 0 && !isPlayer)
        {
            Destroy(gameObject);
        }
    }

    public bool isDown()
    {
        return hitPoints <= 0;
    }

    public int GetCurrentHitPoints()
    {
        return hitPoints;
    }

    public void Kill()
    {
        hitPoints = 0;
    }
}
