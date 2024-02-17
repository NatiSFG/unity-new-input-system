using UnityEngine;
using UnityEngine.InputSystem;

public class NinjaInput : MonoBehaviour {
    private NinjaInputActions input; //the auto generated class

    private void Start() {
        input = new NinjaInputActions();
        input.Ninja.Enable();

        input.Ninja.Rasengan.started += RasenganStarted;
        //adding the method to the performed event so we know when the space key is being pressed
        input.Ninja.Rasengan.performed += RasenganPerformed;
        //can see when the space key has just been let go
        input.Ninja.Rasengan.canceled += RasenganCanceled;
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
}