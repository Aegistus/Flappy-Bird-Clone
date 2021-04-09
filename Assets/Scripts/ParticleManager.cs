using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public GameObject explosionEffect;

    public Player player;

    private bool explosionPlayed = false;

    private void Update()
    {
        if (player.isDead && !explosionPlayed)
        {
            Instantiate(explosionEffect, transform.position, transform.rotation);
            explosionPlayed = true;
        }
    }
}
