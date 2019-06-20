using UnityEngine;

public class PipesHelper : MonoBehaviour

{

    [SerializeField]

    private float speed;



    void Start()

    {

        Vector2 position = transform.position;

        position.y = Random.Range(-0.2F, 0.7F);

        transform.position = position;

        Destroy(gameObject, 6.0F);

    }

    void Update()

    {

        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);

    }

}