using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    [SerializeField] public GameObject[] animals;
    [SerializeField] public GameObject[] potions;

    [SerializeField] private int currentActiveAnimal;
    [SerializeField] protected int newPotion;

    private void OnTriggerEnter(Collider other)
    {
         for (int i = 0; i < potions.Length; i++)
        {
            if (other.gameObject == potions[i])
            {
                currentActiveAnimal = i;
                ChangeAnimal(animals[currentActiveAnimal]);
                break;
            }
        }
        /*if (potions[newPotion])
        {
            currentActiveAnimal = newPotion;
            ChangeAnimal(animals[currentActiveAnimal]);
        }*/
    }

    void ChangeAnimal(GameObject newAnimal)
    {
        foreach (GameObject obj in animals)
        {
            obj.SetActive(false);
        }

        newAnimal.SetActive(true);
    }
}
