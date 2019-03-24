﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed = 10;


    private Transform[] positions;

    private int index = 0;


   

    // Start is called before the first frame update
    void Start()
    {
        positions = Waypoints.positions;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    private void OnDestroy()
    {
        EnemySpwaner.CountEnemyAlive--;
    }


    void Move() 
    {   if (index >= positions.Length) return;
        transform.Translate((positions[index].position - transform.position).normalized * Time.deltaTime * speed);
        if(Vector3.Distance(positions[index].position, transform.position) < 0.5f)
        {
            index++;
        }

        if(index > positions.Length - 1)
        {
            ReachDestination();
        }

    }


    // 到达目的地
    void ReachDestination()
    {
        GameObject.Destroy(gameObject);
    }

}
