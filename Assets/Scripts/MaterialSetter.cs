using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MaterialSetter : MonoBehaviour {

    public Material pureGold;
    public Material midScratchedGold;
    public Material damagedGold;

    public Dropdown dropDown;

    public enum MaterialType {
        PureGold = 0,
        MidScratchedGold = 1,
        DamagedGold = 2,
    }

    private void Awake() {
        SetMaterial((MaterialType)dropDown.value);
        dropDown.onValueChanged.AddListener((int value) => { SetMaterial((MaterialType)value); });
    }

    private void SetMaterial(MaterialType materialType) {
        var renderer = this.gameObject.GetComponent<Renderer>();

        Material chosenMat = pureGold;
        switch (materialType) {
            case MaterialType.PureGold:
                chosenMat = pureGold;
                break;
            case MaterialType.MidScratchedGold:
                chosenMat = midScratchedGold;
                break;
            case MaterialType.DamagedGold:
                chosenMat = damagedGold;
                break;
        }

        if (renderer) {
            renderer.material = chosenMat;
        }
    }
}
