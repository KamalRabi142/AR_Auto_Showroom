using UnityEngine;

public class CarCustomizer : MonoBehaviour
{
    public Renderer carBodyRenderer;
    public Material[] bodyMaterials;
    private int colorIndex = 0;

    public Renderer[] wheelRenderers;
    public Material[] wheelMaterials;
    private int wheelIndex = 0;

    public AudioSource engineAudio;
    private bool engineOn = false;

    public static CarCustomizer activeCar;

    void Start()
    {
        // Only register this car as activeCar if it's Car2 (you can change this logic as needed)
        if (gameObject.name.Contains("Car2"))
        {
            CarCustomizer.activeCar = this;
        }
    }

    public void ChangeColor()
    {
        if (bodyMaterials.Length == 0 || carBodyRenderer == null) return;
        colorIndex = (colorIndex + 1) % bodyMaterials.Length;
        carBodyRenderer.material = bodyMaterials[colorIndex];
    }

    public void ChangeWheels()
    {
        if (wheelMaterials.Length == 0 || wheelRenderers.Length == 0) return;
        wheelIndex = (wheelIndex + 1) % wheelMaterials.Length;
        foreach (var wheel in wheelRenderers)
            wheel.material = wheelMaterials[wheelIndex];
    }

    public void ToggleEngine()
    {
        if (engineAudio == null) return;
        if (engineOn) engineAudio.Stop();
        else engineAudio.Play();
        engineOn = !engineOn;
    }
}
