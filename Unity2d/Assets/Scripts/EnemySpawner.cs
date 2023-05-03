using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    #region CLASS_VARIABLES

    public GameObject enemyPrefab;
    public GameObject enemyClone;
    public GameObject[] enemyArray;
    public List<GameObject> enemyList;

    #endregion

    #region UNITY_METHODS

    private void OnEnable()
    {
        // SpawnEnemy();
    }

    private void OnDisable()
    {
        SpawnEnemy();
    }

    private void Start()
    {
        // SpawnEnemy();
    }

    #endregion

    #region CLASS_METHODS

    public void SpawnEnemy()
    {
        foreach (GameObject enemy in enemyArray)
        {
            Instantiate(enemy, transform.position, transform.rotation);
        }
        
    }

    #endregion
}
