using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _poins;

    private Enemy _enemy;
    private int _cerentePoint;

    private void Start()
    {
        _enemy = GetComponent<Enemy>();
    }

    private void Update()
    {
        if (_enemy.IsKill != true)
        {
            Transform target = _poins[_cerentePoint];

            if (_cerentePoint == 0)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }

            transform.position = Vector2.MoveTowards(transform.position, target.position, 1.5f * Time.deltaTime);

            if (transform.position == target.position)
            {
                _cerentePoint++;

                if (_cerentePoint >= _poins.Length)
                {
                    _cerentePoint = 0;
                }
            }
        }
    }
}
