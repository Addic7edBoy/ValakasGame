using System.Collections;

using UnityEngine;

using UnityEngine.UI;

public class GameHelper : MonoBehaviour

{

    [SerializeField]

    private Text scoreText;

    public GameObject pipes;

    public Button restartButton;

    [HideInInspector]

    public int score;

    void Awake()

    {

        //pipes = Resources.Load("Pipes") as GameObject;

    }

    void Start()

    {

        StartCoroutine(GeneratePipes());

    }

    void Update()

    {

        scoreText.text = "Score: " + score;

    }

    IEnumerator GeneratePipes()

    {

        Vector2 position;

        while (true)

        {

            position = transform.position;

            position.x += 6.0F;

            Instantiate(pipes, position, Quaternion.identity);

            yield return new WaitForSeconds(2.0F);

        }



    }

    public void Restart()

    {
        Application.LoadLevel(Application.loadedLevel);
        Time.timeScale = 1.0F;
    }

}