using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Collector : MonoBehaviour
{
    public List<CollectibleType> collected;

    private void Awake()
    {
        collected = new List<CollectibleType>();
    }

    public void Collect(CollectibleType collectibleType)
    {
        collected.Add(collectibleType);
        if (collectibleType == CollectibleType.Health)
        {
            Destructible destructible = GetComponent<Destructible>();
            if (destructible && destructible.GetCurrentHitPoints() < destructible.maxHitPoints)
            {
                destructible.HealDamage(1);
            }
        }
    }
}
