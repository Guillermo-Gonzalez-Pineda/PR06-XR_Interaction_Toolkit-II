using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CambiarColorAlInteractuar : MonoBehaviour
{
    private XRSimpleInteractable interactable;
    private Renderer rend;
    private Color originalColor;

    private void Awake()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        rend = GetComponent<Renderer>();
        originalColor = rend.material.color;

        // Eventos para cuando el rayo apunta al objeto
        interactable.hoverEntered.AddListener(OnHoverEnter);
        interactable.hoverExited.AddListener(OnHoverExit);
        
        // Evento para cuando se selecciona (disparo/gatillo)
        interactable.selectEntered.AddListener(OnSelect);
    }

    private void OnHoverEnter(HoverEnterEventArgs args)
    {
        rend.material.color = Color.cyan; // Color cuando el rayo apunta
    }

    private void OnHoverExit(HoverExitEventArgs args)
    {
        rend.material.color = originalColor; // Vuelve al color original
    }

    private void OnSelect(SelectEnterEventArgs args)
    {
        Debug.Log("Has interactuado con el cubo lejano usando el Ray Interactor");
        // Aquí puedes añadir más lógica, como cambiar el color momentáneamente
        rend.material.color = Color.magenta;
    }
}
