using System;
using Brix.State;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [CreateAssetMenu(menuName = Constants.Menus.CONDITIONS + "Input Button Pressed")]
    public class InputButtonPressed : Condition {
        [SerializeField]private StringReference buttonName;
        [SerializeField]private Constants.KeyState keyState;

        public override bool CheckCondition() {
            switch (keyState) {
                case Constants.KeyState.OnCurrent:
                    return Input.GetButton(buttonName.Value);
                case Constants.KeyState.OnDown:
                    return Input.GetButtonDown(buttonName.Value);
                case Constants.KeyState.OnUp:
                    return Input.GetButtonUp(buttonName.Value);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}