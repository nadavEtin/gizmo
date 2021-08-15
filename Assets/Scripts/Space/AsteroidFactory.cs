using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Space
{
    public class AsteroidFactory : ObstacleFactory
    {
        protected override GameObject Adjust(GameObject obstacle)
        {
            var asteroid = obstacle.GetComponent<Asteroid>();
            asteroid.RotationDirection = Vector3.left;
            return obstacle;
        }
    }
}