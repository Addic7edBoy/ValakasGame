using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    public GameObject bomb;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn() {
        while (true) {
            Instantiate(bomb, new Vector2(Random.Range(-10f, 10f), 5.47f), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
    }

}
