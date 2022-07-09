using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpawnPoints))]

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _coin;

    private SpawnPoints _points;

    private void Start()
    {
        _points = GetComponent<SpawnPoints>();
        StartCoroutine(CreateEnemies());
    }

    private IEnumerator CreateEnemies()
    {
        foreach (var coin in _points.Spawn)
        {
            yield return Instantiate(_coin, coin.transform.position, Quaternion.identity);
        }
    }
}
