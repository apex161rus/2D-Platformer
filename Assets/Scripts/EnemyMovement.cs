using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform[] _poins;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    //private Enemy _enemy;
    private int _cerentePoint;

    private void Start()
    {

    }

    private void Update()
    {
        Transform target = _poins[_cerentePoint];
        transform.position = Vector2.MoveTowards(transform.position, target.position, 1.5f * Time.deltaTime);

        if (transform.position == target.position)
        {
            _cerentePoint++;
            if (_cerentePoint >= _poins.Length)
            {
                _cerentePoint = 0;
            }
        }

        //Vector2.MoveTowards(_rigidbody2D.position, target.position, 1f * Time.deltaTime);
    }
}
