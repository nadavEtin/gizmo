using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK74BulletsFactory : WeaponBulletFactory
{
    #region Methods

    protected override WeaponBullet CreateInternal(float damage)
    {
        return new AK74Bullet(damage);
    }

    #endregion
}
