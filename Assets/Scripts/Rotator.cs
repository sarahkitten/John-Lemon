﻿using UnityEngine;
using UnityEngine.UI;
public class Rotator : MonoBehaviour
{
    public GameObject player;
    private Vector3 _angles;
    void Start()
    {
        // Reuse rather than creating this every update.        
        _angles = new Vector3(0.0f, 1.0f, 0.0f);
    }

    void FixedUpdate()
    {
        // Calculate vector from pickup to player.        
        Vector3 d = player.transform.position - transform.position;

        // Normalize to a direction.        
        d.Normalize();

        float angle = Mathf.Rad2Deg * Mathf.Acos(Vector3.Dot(Vector3.forward, d));

        Vector3 cross = Vector3.Cross(Vector3.forward, d);
        if (cross.y < 0.0f)
        {
            angle = -angle;
        }

        _angles.y = angle;
        transform.eulerAngles = _angles;

    }
}