using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsManager : MonoBehaviour
{
    [SerializeField]Asteroid asteroid;
    [SerializeField]int numberOfAsteroidsOnAnAxis = 10;
    [SerializeField]int gridSpacing = 100;

    void Start() {
        PlaceAsteroids();
    }

    void PlaceAsteroids () {
        for(int x = 0; x < numberOfAsteroidsOnAnAxis; x++) {
            for(int y = 0; y < numberOfAsteroidsOnAnAxis; y++) {
                for(int z = 0; z < numberOfAsteroidsOnAnAxis; z++) {
                    InstantiateAsteroids(x, y, z);
                }
            }
        }
    }

    void InstantiateAsteroids(int x, int y, int z) {
            Instantiate(asteroid, 
                     new Vector3(transform.position.x + (x * gridSpacing) + AsteroidOffSet(),
                                 transform.position.y + (y * gridSpacing) + AsteroidOffSet(),
                                 transform.position.z + (z * gridSpacing) + AsteroidOffSet()),
                        Quaternion.identity, 
                        transform);
    }

    float AsteroidOffSet() {
       return Random.Range(-gridSpacing/2f, gridSpacing/2f);
    }
}

