using UnityEngine;
using UnityEngine.InputSystem;

public class ClickMover : MonoBehaviour
{
    public float stepSize = 1f;
    [SerializeField] private InputAction moveUp = new InputAction(type: InputActionType.Button);
    [SerializeField] private InputAction moveDown = new InputAction(type: InputActionType.Button);
    [SerializeField] private InputAction moveLeft = new InputAction(type: InputActionType.Button);
    [SerializeField] private InputAction moveRight = new InputAction(type: InputActionType.Button);

    void OnEnable()
    {
        moveUp.Enable();
        moveDown.Enable();
        moveLeft.Enable();
        moveRight.Enable();
    }

    void OnDisable()
    {
        moveUp.Disable();
        moveDown.Disable();
        moveLeft.Disable();
        moveRight.Disable();
    }

    void Update()
    {
        if (moveUp.WasPerformedThisFrame())
        {
            transform.position += new Vector3(0, stepSize, 0);
        }
        else if (moveDown.WasPerformedThisFrame())
        {
            transform.position += new Vector3(0, -stepSize, 0);
        }
        else if (moveLeft.WasPerformedThisFrame())
        {
            transform.position += new Vector3(-stepSize, 0, 0);
        }
        else if (moveRight.WasPerformedThisFrame())
        {
            transform.position += new Vector3(stepSize, 0, 0);
        }
    }
}