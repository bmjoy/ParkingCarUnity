using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class Extensions
{
    public static T[] Append<T>(this T[] array, T item)
    {
        if (array == null)
        {
            return new T[] { item };
        }
        T[] result = new T[array.Length + 1];
        array.CopyTo(result, 0);
        result[array.Length] = item;
        return result;
    }
    public static T[] Remove<T>(this T[] array, int index)
    {
        T[] result = new T[array.Length - 1];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i != index)
            {
                result[i] = array[i + j];
            }
            else
            {
                j = 1;
            }
        }
        return result;
    }
}


public class CarSpawner : MonoBehaviour
{

    [SerializeField]
    private GameObject[] carReference;

    private AgentScript spawnedCar;
    private AgentScript[] spawnedCars;

    [SerializeField]
    private Transform topPos, rightPos, bottomPos, leftPos;

    private int randomIndex;
    private int randomSide;

    public static string parkingTag;

    private string[] listParks = { "Park1",
        "Park2",
        "Park3",
        "Park4",
        "Park5",
        "Park6",
        "Park7",
        "Park8"
    };
    private string[] listEntrances = { "GetOut1",
        "GetOut2",
        "GetOut3",
        "GetOut4"
    };

    private string[] occupyParking = { };

    // Start is called before the first frame update
    void Start()
    {
        if (occupyParking.Length < 8)
        {
            StartCoroutine(SpawnCars());
        }
    }

    void randomParkingTag()
    {
        parkingTag = listParks[Random.Range(0, 8)];
        foreach (string x in occupyParking)
        {
            if (x.Equals(parkingTag))
            {
                randomParkingTag();
                return;
            }
        }
        string[] passingTags = occupyParking.Append(parkingTag);
        occupyParking = passingTags;
    }

    void randomGetOutTag()
    {
        parkingTag = listEntrances[Random.Range(0, 4)];
        // occupyParking.Remove();
    }

    IEnumerator SpawnCars()
    {
        bool switchCar = true;
        while (occupyParking.Length < 10)
        {
            if (occupyParking.Length < 8)
            {
                yield return new WaitForSeconds(Random.Range(1, 5));

                randomParkingTag();
                randomSide = Random.Range(0, 4);
                spawnedCar = (Instantiate(carReference[0])).GetComponent<AgentScript>();
                if (randomSide == 0)
                {
                    spawnedCar.transform.position = topPos.position;

                }
                else if (randomSide == 1)
                {
                    spawnedCar.transform.position = rightPos.position;

                }
                else if (randomSide == 2)
                {
                    spawnedCar.transform.position = bottomPos.position;

                }
                else
                {
                    spawnedCar.transform.position = leftPos.position;

                }

                AgentScript[] passingCars = spawnedCars.Append(spawnedCar);
                spawnedCars = passingCars;

            }
            else
            {
                break;
            }
            //if (occupyParking.Length > 0)
            //{
            //    yield return new WaitForSeconds(Random.Range(15, 20));
            //    int randomCar = Random.Range(0, occupyParking.Length);
            //    randomGetOutTag();
            //    spawnedCars[randomCar].getOut();
            //    print(spawnedCars.Length);
            //    print(occupyParking.Length);
            //    AgentScript[] passingCarsList = spawnedCars.Remove(randomCar);
            //    spawnedCars = passingCarsList;
            //    string[] passingParkingList = occupyParking.Remove(randomCar);
            //    occupyParking = passingParkingList;
            //    print(spawnedCars.Length);
            //    print(occupyParking.Length);
            //}
        }
    }
}
