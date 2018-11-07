using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb; // The rigidbody on the player objet

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        // Make sure our speed caps out at 15
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, 15f);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // keep increasing velocity if hitting a speed object
        if (collision.gameObject.GetComponent<SetEffect>() && collision.gameObject.GetComponent<SetEffect>().effect == EffectEnum.Effects.speed)
        {
            rb.AddForce(rb.velocity * 0.05f, ForceMode2D.Impulse);  
        }
    }
}
