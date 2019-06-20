using UnityEngine;
using System.Collections;

public class BirdHelper : MonoBehaviour
{
    public float force;
    private new Rigidbody2D rigidbody;
    public GameHelper gameHelper;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        //gameHelper = Camera.main.GetComponent<GameHelper>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            rigidbody.AddForce(Vector2.up * (force - rigidbody.velocity.y), ForceMode2D.Impulse);
        rigidbody.MoveRotation(rigidbody.velocity.y * 2.0F);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        gameHelper.restartButton.gameObject.SetActive(true);
        Time.timeScale = 0.0F;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        gameHelper.score++;
    }
}