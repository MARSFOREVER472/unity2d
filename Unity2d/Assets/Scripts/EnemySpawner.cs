using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    #region CLASS_VARIABLES

    public GameObject enemyPrefab;

    #endregion

    #region UNITY_METHODS

    private void Awake()
    {
        SpawnEnemy();
    }

    #endregion

    #region CLASS_METHODS

    public void SpawnEnemy()
    {
        Instantiate(enemyPrefab, this.transform.position, this.transform.rotation);
    }

    #endregion
}
