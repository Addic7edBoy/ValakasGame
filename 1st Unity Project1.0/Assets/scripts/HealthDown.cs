using UnityEngine;

public class HealthDown : MonoBehaviour
{

    private float destroyTime = 5f;
    [SerializeField]
 
    void Update()
    {
            Destroy(gameObject, 5f);
        if(transform.position.y > 4.6f)
            transform.position -= new Vector3(0, destroyTime * Time.deltaTime, 0);
    }
}
