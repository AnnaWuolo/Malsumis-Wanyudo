﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject Bullet;

    private PlayerStats stats;
    private float playerPistolCooldown;
    private float timeBetweenShoots;
    
    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if(stats.pistolCooldown.Value > 0)
        {
            playerPistolCooldown -= Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space) == true && playerPistolCooldown < 0)
        {
            timeBetweenShoots = stats.pistolCooldown.Value;
           
            Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y,0), transform.rotation);
            playerPistolCooldown = stats.pistolCooldown.Value;
        }
    }
}
