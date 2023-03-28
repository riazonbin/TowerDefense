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

    private EnemySpawnerScript _spawnerScript;
    // Start is called before the first frame update
    void Start()
    {
        _spawnerScript= GetComponentInParent<EnemySpawnerScript>();

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

        transform.position = Vector3.MoveTowards(transform.position, _target, 2 * Time.deltaTime);

        if (_index == wayPointsList.Count - 1)
        {
            if(transform.position == _target)
            {
                _spawnerScript.enemiesOnDisplay--;
                Destroy(gameObject);
                return;
            }
            return;
        }


        if (transform.position == _target)
        {
            _index++;
            _target = wayPointsList[_index].position;
        }
    }
}
