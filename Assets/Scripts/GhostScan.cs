using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostScan : MonoBehaviour
{
    public GameObject player;
    private Vector3 _angles;

    public Transform JohnLemon;
    public Transform Ghost;


    // Start is called before the first frame update
    void Start()
    {
        _angles = new Vector3(0.0f, 1.0f, 0.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 distance = JohnLemon.position - Ghost.position;

        if (distance.magnitude < 3)
        {

            float maxSpeed = 1000.0f;
            float minSpeed = 100.0f;
            float alpha = 0.1f; // normalized to [0.0, 1.0] scale        
            float interpolatedSpeed = (1.0f - alpha) * minSpeed + alpha * maxSpeed;
            transform.Rotate(_angles * interpolatedSpeed * Time.deltaTime);
        }
    }
}