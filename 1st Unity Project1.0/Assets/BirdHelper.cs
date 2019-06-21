using UnityEngine;
using System.Collections;

public class BirdHelper : MonoBehaviour
{
    public float force;
    private new Rigidbody2D rigidbody;
    public GameHelper gameHelper;
    public bool guipause;

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
        //gameHelper.restartButton.gameObject.SetActive(true);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Sveta")
        {
            gameHelper.score++;
        }
        if (other.tag == "Sasha")
        {
            gameHelper.sasha++;
        }
        if (other.tag == "Death")
        {

            guipause = true;
        }

    }
    public void OnGUI()
    {
        if (guipause == true)
        {
            Time.timeScale = 0.0F;
            Cursor.visible = true;// включаем отображение курсора
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2) - 100f, 150f, 45f), "Restart"))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
            if (GUI.Button(new Rect((float)(Screen.width / 2), (float)(Screen.height / 2), 150f, 45f), "Main Menu"))
            {
                Application.LoadLevel("Main_Menu"); // здесь при нажатии на кнопку загружается другая сцена, вы можете изменить название сцены на свое

            }
            //void OnTriggerEnter2D(Collider2D other)
            //{
            //    gameHelper.sasha++;
            // }
        }
    }
}