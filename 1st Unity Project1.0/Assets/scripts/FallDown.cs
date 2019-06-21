using UnityEngine;

public class FallDown : MonoBehaviour
{
    private float FallSpeed = 5f;
    [SerializeField]
    void Update(){
        if (transform.position.y < -4f)
            Destroy(gameObject);
        transform.position -= new Vector3(0, FallSpeed * Time.deltaTime, 0);
    }
}
