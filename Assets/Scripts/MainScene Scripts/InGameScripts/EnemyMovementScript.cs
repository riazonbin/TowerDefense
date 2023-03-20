using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
    [HideInInspector]
    public List<Transform> wayPointsList;
    private Vector3 _target;
    private int _index = 2;
    // Start is called before the first frame update
    void Start()
    {
        wayPointsList = (GameObject.FindGameObjectWithTag("RoutePoints").GetComponentsInChildren<Transform>()).ToList();
        _target = wayPointsList[1].position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget();
    }

    void MoveToTarget()
    {
        GetComponent<SpriteRenderer>().flipX = transform.position.x - _target.x >= 0;

        transform.position = Vector3.MoveTowards(transform.position, _target, 2 * Time.deltaTime);

        if (_index + 2 > wayPointsList.Count)
        {
            return;
        }
        if (transform.position == _target)
        {
            _index++;
            _target = wayPointsList[_index].position;
        }
    }
}
