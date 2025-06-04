using UnityEngine;

public class UICustomizationBridge : MonoBehaviour
{
    public void OnChangeColor()
    {
        if (CarCustomizer.activeCar != null)
            CarCustomizer.activeCar.ChangeColor();
    }

    public void OnChangeWheels()
    {
        if (CarCustomizer.activeCar != null)
            CarCustomizer.activeCar.ChangeWheels();
    }

    public void OnToggleEngine()
    {
        if (CarCustomizer.activeCar != null)
            CarCustomizer.activeCar.ToggleEngine();
    }
}
