using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ChargeBar : MonoBehaviour {
    [SerializeField] private int chargeUpSpeed = 5;
    [SerializeField] private int chargeDownSpeed = 3;
    
    private Slider slider;
    private UIInputAsset input;
    private bool isCharging;
    private int oneSec = 1;

    private bool IsChargeLeft => slider.value > 0;

    private void Start() {
        slider = GetComponent<Slider>();
        input = new UIInputAsset();
        input.UI.Enable();

        input.UI.ChargeBar.started += ChargeStarted;
        input.UI.ChargeBar.canceled += ChargeCanceled;
    }

    private void ChargeStarted(InputAction.CallbackContext obj) {
        isCharging = true;
        StartCoroutine(GainCharge());
    }

    private void ChargeCanceled(InputAction.CallbackContext obj) {
        isCharging = false;
        StartCoroutine(LoseCharge());
    }

    private IEnumerator GainCharge() {
        while (isCharging) {
            slider.value += (oneSec * Time.deltaTime) / chargeUpSpeed;
            yield return null;
        }
    }

    private IEnumerator LoseCharge() {
        while (IsChargeLeft) {
            slider.value -= (oneSec * Time.deltaTime) / chargeDownSpeed;
            yield return null;
        }
    }
}
