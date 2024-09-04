using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubespinner : MonoBehaviour
{
    [SerializeField] float speedx = 1, speedy = 1, speedz = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the cube by speed vars, multiplied by time delta.
        transform.Rotate(new(speedx * Time.deltaTime, speedy * Time.deltaTime, speedz * Time.deltaTime));
    }
}
