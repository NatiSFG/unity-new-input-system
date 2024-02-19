using UnityEngine;
using UnityEngine.InputSystem;

public class NinjaInput : MonoBehaviour {
    [SerializeField] private int rotateSpeed = 30;
    [SerializeField] private int moveSpeed = 5;

    private NinjaInputAsset input;

    private void Start() {
        input = new NinjaInputAsset();
        input.ToggleActionMaps.Enable();
        input.Orient.Enable();

        Debug.Log("Orient is enabled! \n\nPress T to toggle between action maps. \nOrient: AD keys \nMovement: WASD keys");
        input.ToggleActionMaps.Toggle.performed += TogglePerformed;
    }

    private void Update() {
        if (input.Orient.enabled)
            CalculateRotation();
        if (input.Movement.enabled)
            CalculateMovement();
    }

    private void TogglePerformed(InputAction.CallbackContext obj) {
        if (input.Orient.enabled) {
            Debug.Log("Switching to Movement");
            input.Orient.Disable();
            input.Movement.Enable();
        }
        else {
            Debug.Log("Switching to Orient");
            input.Orient.Enable();
            input.Movement.Disable();
        }
    }

    private void CalculateRotation() {
        float rotateDirection = input.Orient.Rotate.ReadValue<float>();
        transform.Rotate(Vector3.up * rotateDirection * Time.deltaTime * rotateSpeed);
    }

    private void CalculateMovement() {
        Vector2 move = input.Movement.Movement.ReadValue<Vector2>();
        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * moveSpeed);
    }
}




