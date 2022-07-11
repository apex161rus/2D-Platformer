using System.Collections;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private GameObject[] _spawnPositions;

    private void Start()
    {
        StartCoroutine(CreateEnemies());
    }

    private IEnumerator CreateEnemies()
    {
        var waitForSeconds = new WaitForSeconds(1f);

        foreach (var coin in _spawnPositions)
        {
            yield return waitForSeconds;
            Instantiate(_coin, coin.transform.position, Quaternion.identity);
        }
    }
}
