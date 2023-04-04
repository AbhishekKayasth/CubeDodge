using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour {

    private Rigidbody Brb;
    public float BlockSpeed;

    void Start()
    {
        Brb = GetComponent<Rigidbody>();
        BlockSpeed += Time.timeSinceLevelLoad / 20f;
    }

    void Update()
    {
        Brb.AddForce(0f, 0f, -BlockSpeed);
        if (Brb.position.y <= -2)
        {
            Destroy(gameObject);
        }
    }
}
