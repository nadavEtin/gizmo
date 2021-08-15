using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    void Fire(IDamagable damagable);

    void Reload();

    int GetCurrentAmmo();
}
