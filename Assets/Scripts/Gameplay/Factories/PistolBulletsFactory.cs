using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBulletsFactory : WeaponBulletFactory
{
    #region Methods

    protected override WeaponBullet CreateInternal(float damage)
    {
        return new PistolBullet(damage);
    }

    #endregion
}
