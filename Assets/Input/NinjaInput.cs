using UnityEngine;
using UnityEngine.InputSystem;

public class NinjaInput : MonoBehaviour {
    [SerializeField] private int speed = 5;
    
    private NinjaInputAsset input;

    private void Start() {
        input = new NinjaInputAsset();
        input.Ninja.Enable();

        input.Ninja.Walk.performed += WalkPerformed;
    }

    private void Update() {
        CalculateMovement();
    }

    private void CalculateMovement() {
        Vector2 move = input.Ninja.Walk.ReadValue<Vector2>();
        transform.Translate(new Vector3(move.x, 0, move.y) * Time.deltaTime * speed);
    }

    private void WalkPerformed(InputAction.CallbackContext obj) {
        Debug.Log($"X: {obj.ReadValue<Vector2>().x} Y: {obj.ReadValue<Vector2>().y}");

        Vector2 movement = obj.ReadValue<Vector2>();
        transform.Translate(movement * Time.deltaTime * speed);
    }
}
