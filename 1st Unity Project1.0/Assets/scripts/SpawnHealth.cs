using System.Collections;
using UnityEngine;

public class SpawnHealth : MonoBehaviour
{
    public GameObject health;
    void Start()
    {
        StartCoroutine(HealthSpawn());
    }

   private IEnumerator HealthSpawn()
    {
        while (true)
        {
            Instantiate(health, new Vector2(Random.Range(-10f, 10f), 5.47f), Quaternion.identity);
            yield return new WaitForSeconds(6f);
        }
    }

}