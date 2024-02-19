using UnityEngine;
using UnityEngine.InputSystem;

public class ColorInput : MonoBehaviour {
    private ColorInputAsset input;
    private new MeshRenderer renderer;

    private void Start() {
        renderer = GetComponent<MeshRenderer>();
        input = new ColorInputAsset();
        input.Color.Enable();

        input.Color.RandomColor.performed += RandomColorPerformed;
    }

    private void RandomColorPerformed(InputAction.CallbackContext obj) {
        renderer.material.color = Random.ColorHSV();
    }
}
