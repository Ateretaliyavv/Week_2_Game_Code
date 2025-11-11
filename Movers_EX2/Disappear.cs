using UnityEngine;
using UnityEngine.InputSystem;

public class Disappear : MonoBehaviour
{
    // Button action for mouse click
    [SerializeField]
    private InputAction clickAction = new InputAction(
        type: InputActionType.Button,
        binding: "<Mouse>/leftButton"
    );

    public Camera cam; // Camera to cast ray from
    public LayerMask clickableLayers = ~0; // Layers that can be clicked (default: all layers)

    private Renderer rend;
    private bool isVisible = true;

    void OnEnable() => clickAction.Enable();
    void OnDisable() => clickAction.Disable();

    // Initialize references
    void Start()
    {
        if (cam == null) cam = Camera.main;
        rend = GetComponentInChildren<Renderer>();
        if (cam == null) Debug.LogError("No MainCamera found (tag your camera as MainCamera).");
        if (rend == null) Debug.LogError("No Renderer found on this object or its children.");
    }

    // Handle mouse click input
    void Update()
    {
        // Check if the click action was performed this frame
        if (clickAction.WasPressedThisFrame())
        {
            if (cam == null) return;

            Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());
            // Cast a ray from the camera through the mouse position
            if (Physics.Raycast(ray, out RaycastHit hit, 1000f, clickableLayers))
            {
                //Hit this object or its children
                if (hit.transform == transform || hit.transform.IsChildOf(transform))
                {
                    isVisible = !isVisible;
                    rend.enabled = isVisible;
                }
            }
        }
    }
}