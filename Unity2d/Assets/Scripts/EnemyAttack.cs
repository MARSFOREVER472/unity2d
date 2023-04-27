using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    #region CLASS_VARIABLES

    public PlayerHealth playerHealth;

    public int damagePoints = 1;

    #endregion

    #region UNITY_METHODS

    private void Update()
    {
        PlayerInputs();
    }

    #endregion

    #region CLASS_METHODS

    public void PlayerInputs()
    {
        if (Input.GetKeyDown(KeyCode.T) == true)
        {
            DealDamage();
        }
    }

    public void DealDamage()
    {
        playerHealth.TakeDamage(damagePoints);
    }

    #endregion
}
