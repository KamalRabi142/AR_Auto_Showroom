using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections.Generic;

public class CarPlacementManager : MonoBehaviour
{
    public CarSelector carSelector; // Drag your CarSelectorManager here
    private ARRaycastManager raycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    // Store references to placed cars
    private Dictionary<string, GameObject> placedCars = new Dictionary<string, GameObject>();

    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (Input.touchCount == 0) return;

        Touch touch = Input.GetTouch(0);
        if (touch.phase != TouchPhase.Began) return;

        if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
        {
            Pose hitPose = hits[0].pose;

            // Get the name of the selected car prefab
            string selectedName = carSelector.selectedCar.name;

            // If we've already placed this car type, do nothing
            if (placedCars.ContainsKey(selectedName)) return;

            // Otherwise, instantiate it
            GameObject newCar = Instantiate(carSelector.selectedCar, hitPose.position, hitPose.rotation);
            placedCars[selectedName] = newCar;
        }
    }
}
