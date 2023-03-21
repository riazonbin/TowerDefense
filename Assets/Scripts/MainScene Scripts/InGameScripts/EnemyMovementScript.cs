using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
    [HideInInspector]
    public List<Transform> wayPointsList;
    private Vector3 _target;
    private int _index = 1;
    // Start is called before the first frame update
    void Start()
    {
        var routePointsObject = GameObject.FindGameObjectWithTag("RoutePoints");

        var wayPointsRoutesCount = routePointsObject.transform.childCount;

        var route = routePointsObject.transform.GetChild(Random.Range(0, wayPointsRoutesCount));


        wayPointsList = route.GetComponentsInChildren<Transform>().ToList();

        _target = wayPointsList[_index].position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToTarget();
    }

    void MoveToTarget()
    {
        GetComponent<SpriteRenderer>().flipX = transform.position.x - _target.x >= 0;

        transform.position = Vector3.MoveTowards(transform.position, _target, 4 * Time.deltaTime);

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
