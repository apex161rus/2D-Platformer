using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        var waitForSeconds = new WaitForSeconds(2f);

        foreach (var enemy in _points.Spawn)
        {
            yield return waitForSeconds;
            Instantiate(_coin, enemy.transform.position, Quaternion.identity);
        }
    }
}
