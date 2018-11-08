using UnityEngine;

public class Player : MonoBehaviour
{

    #region Variables
    Rigidbody2D rb; // The rigidbody on the player object
    #endregion

    #region Properties
    public Vector2 SpriteCenter { get; set; }
    #endregion

    #region Unity Methods
    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        // Get center of sprite
        SpriteCenter = new Vector2(GetComponent<SpriteRenderer>().sprite.bounds.size.x / 2 * transform.localScale.x, GetComponent<SpriteRenderer>().sprite.bounds.size.y / 2 * transform.localScale.y);

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void FixedUpdate()
    {
        // Make sure our speed caps out at 15
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, Constants.BALL_MAX_VELOCITY);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        // keep increasing velocity if hitting a speed object
        if (collision.gameObject.GetComponent<SetEffect>() && collision.gameObject.GetComponent<SetEffect>().effect == EffectEnum.Effects.speed)
        {
            rb.AddForce(rb.velocity * 0.05f, ForceMode2D.Impulse);
        }
    }

    #endregion
}
