using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadShipFactory : ObstacleFactory
{
    protected override GameObject Adjust(GameObject obstacle)
    {
        var asteroid = obstacle.GetComponent<DeadShip>();
        asteroid.RotationDirection = Vector3.right;
        return obstacle;
    }
}
