using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CambiarColorAlSeleccionar : MonoBehaviour
{
    private XRGrabInteractable grab;
    private Renderer rend;
    private Color originalColor;

    private void Awake()
    {
        grab = GetComponent<XRGrabInteractable>();
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;

        grab.selectEntered.AddListener(OnSelect);
        grab.selectExited.AddListener(OnDeselect);
    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        rend.material.color = Color.yellow; // Color al seleccionar
    }

    private void OnDeselect(SelectExitEventArgs args)
    {
        rend.material.color = originalColor; // Vuelve al color original
    }
}
