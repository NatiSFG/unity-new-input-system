using UnityEngine;
using UnityEngine.InputSystem;

public class BounceInput : MonoBehaviour {
    [SerializeField] private float forceMultiplier = 25;
    
    private BounceInputAsset input;
    private Rigidbody rb;

    private void Start() {
        rb = GetComponent<Rigidbody>();

        input = new BounceInputAsset();
        input.Ball.Enable();

        input.Ball.Bounce.canceled += PartialBounce;
        input.Ball.Bounce.performed += FullBounce;
    }

    private void PartialBounce(InputAction.CallbackContext obj) {
        double pressTime = obj.duration;
        rb.AddForce(Vector3.up * (forceMultiplier * (float)pressTime), ForceMode.Impulse);
    }

    private void FullBounce(InputAction.CallbackContext obj) {
        Debug.Log("Full Bounce!");
        rb.AddForce(Vector3.up * forceMultiplier, ForceMode.Impulse);
    }
}
