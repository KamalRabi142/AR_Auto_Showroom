using UnityEngine;

public class CarSelector : MonoBehaviour
{
    public GameObject car1Prefab;
    public GameObject car2Prefab;

    [HideInInspector]
    public GameObject selectedCar;

    void Start()
    {
        selectedCar = car1Prefab; // Default
    }

    public void SelectCar1()
    {
        selectedCar = car1Prefab;
    }

    public void SelectCar2()
    {
        selectedCar = car2Prefab;
    }
}
