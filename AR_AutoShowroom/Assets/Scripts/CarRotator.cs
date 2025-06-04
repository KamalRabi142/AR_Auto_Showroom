using UnityEngine;
using UnityEngine.UI;

public class CarRotator : MonoBehaviour
{
    public float rotationSpeed = 10f;
    private bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }

    public void ToggleRotation()
    {
        isRotating = !isRotating;
    }

    public void SetRotationSpeed(float speed)
    {
        rotationSpeed = speed;
    }
}
