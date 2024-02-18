using UnityEngine;
using UnityEngine.InputSystem;

public class NinjaInput : MonoBehaviour {
    private NinjaInputActions input; //the auto generated class

    private void Start() {
        input = new NinjaInputActions();
        input.Ninja.Enable();

        NinjaSubbedMethods();
    }

    private void NinjaSubbedMethods() {
        input.Ninja.Rasengan.started += RasenganStarted;
        input.Ninja.Rasengan.performed += RasenganPerformed;
        input.Ninja.Rasengan.canceled += RasenganCanceled;

        input.Ninja.Walk.performed += WalkPerformed;

        input.Ninja.Run.performed += RunPerformed;
        input.Ninja.Run.canceled += RunCanceled;

        input.Ninja.Die.performed += DiePerformed;
    }

    private void RasenganStarted(InputAction.CallbackContext context) {
        Debug.Log("Rasengan starting!! Charging up! " + context);
    }

    private void RasenganPerformed(InputAction.CallbackContext context) {
        Debug.Log("Rasengan is happening! " + context);
    }

    private void RasenganCanceled(InputAction.CallbackContext context) {
        Debug.Log("Finished Rasengan " + context);
    }

    private void WalkPerformed(InputAction.CallbackContext context) {
        Debug.Log($"Walking {context}");
    }

    private void RunPerformed(InputAction.CallbackContext context) {
        Debug.Log($"Running {context}");
    }

    private void RunCanceled(InputAction.CallbackContext context) {
        Debug.Log("Run Canceled " + context);
    }
    
    private void DiePerformed(InputAction.CallbackContext obj) {
        Debug.Log("Dying " + obj);
    }
}