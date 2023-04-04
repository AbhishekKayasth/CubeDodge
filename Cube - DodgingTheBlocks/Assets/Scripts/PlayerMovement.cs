  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed;
    private Rigidbody rb;
    public float slowness = 10f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void FixedUpdate ()
    {
        if (Input.GetKey("left") ||Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-movementSpeed, 0f, 0f * Time.deltaTime);
        }
        if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(movementSpeed, 0f, 0f * Time.deltaTime);
        }
        if(Input.GetKey("j"))
        {
            rb.AddForce(0f, 100f, 0f);
        }
        if (Input.GetKeyDown("right ctrl")) 
        {
            StartCoroutine(SlowMo());
        }
	}

     IEnumerator SlowMo()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
    }

    
}
