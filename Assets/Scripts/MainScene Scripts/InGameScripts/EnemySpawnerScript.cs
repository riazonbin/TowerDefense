using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    [SerializeField]
    Transform enemyPrefab;

    [SerializeField]
    Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerator Spawn()
    {
        var enemy = Instantiate(enemyPrefab, spawnPoint,  false);
        yield return new WaitForSeconds(2);

        yield return StartCoroutine(Spawn());
    }
}
