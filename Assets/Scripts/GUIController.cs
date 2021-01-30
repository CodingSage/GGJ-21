using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIController : MonoBehaviour
{
    public List<GameObject> healthIndicators;
    public Destructible player;

    private void Start()
    {
        if (player == null || healthIndicators == null || healthIndicators.Count == 0)
        {
            throw new MissingComponentException("GUI Controller is missing its components");
        }
    }

    private void Update()
    {
        UpdateHealthIndicator();
    }

    public void UpdateHealthIndicator()
    {
        int health = player.GetCurrentHitPoints();
        for (int i = 0; i < healthIndicators.Count; ++i)
        {
            GameObject healthMarker = healthIndicators[i];
            healthMarker.SetActive(i < health);
        }
    }
}
