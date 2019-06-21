using System.Collections;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coin;
    private bool WaitT = false;
    void Start()
    {
        StartCoroutine(CoinSpawn());
    }

    private IEnumerator CoinSpawn()
    {
        
        yield return new WaitForSeconds(3f);
        while (true)
        {
            Instantiate(coin, new Vector2(Random.Range(-10f, 10f), 5.47f), Quaternion.identity);
            yield return new WaitForSeconds(10f);
        }
    }

}