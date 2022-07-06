using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnPositions;

    public GameObject[] Spawn => _spawnPositions;
}
