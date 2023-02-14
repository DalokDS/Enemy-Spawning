using System.Collections;
using UnityEngine;

public class EnemySpawningArea : MonoBehaviour
{
    [SerializeField] private float _spawningDuration;

    private EnemySpawner[] _spawners;

    private void Awake()
    {
        _spawners = GetComponentsInChildren<EnemySpawner>();
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        foreach(EnemySpawner spawner in _spawners)
        {
            spawner.SpawnEnemy();

            yield return new WaitForSeconds(_spawningDuration);
        }
        
    }
}