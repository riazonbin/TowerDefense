using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    [SerializeField]
    List<Transform> enemyPrefabs = new List<Transform>();

    [SerializeField]
    Transform spawnPoint;

    [SerializeField]
    int maxEnemiesOnWage;

    [SerializeField]
    int maxEnemiesOnDisplay;

    [HideInInspector]
    public int enemiesOnDisplay;

    [HideInInspector]
    public int totalEnemiesOnWage;



    // Start is called before the first frame update
    void Start()
    {
        enemiesOnDisplay = 0;
        totalEnemiesOnWage = 0;

        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
    }

    public IEnumerator Spawn()
    {
        while (true)
        {
            if (totalEnemiesOnWage >= maxEnemiesOnWage)
            {
            }
            else if (enemiesOnDisplay < maxEnemiesOnDisplay)
            {
                var enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Count)];
                var enemy = Instantiate(enemyPrefab, spawnPoint, false);

                enemiesOnDisplay++;
                totalEnemiesOnWage++;
            }

            yield return new WaitForSeconds(2);
        }
    }

    public void StartNewWage()
    {
        totalEnemiesOnWage = 0;
    }
}
