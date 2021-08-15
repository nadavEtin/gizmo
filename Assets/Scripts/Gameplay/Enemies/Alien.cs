using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : IDamagable
{
    #region Methods

    public void TakeDamage(float damage)
    {
        Debug.Log("I've been shot!");
    }

    #endregion
}