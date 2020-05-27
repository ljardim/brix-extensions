using System;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Assign Input Button To Variable")]
    public class AssignInputButtonToVariable : AtomAction {
        [Header("Inputs")]
        [SerializeField]private StringReference buttonName;
        [SerializeField]private Constants.KeyState targetKeyState;
        [SerializeField]private BoolReference onlyAssignTrue = new BoolReference(false);

        [Header("Outputs")]
        [SerializeField]private BoolReference variable;

        public override void Do() {
            bool buttonPressed;
            switch (targetKeyState) {
                case Constants.KeyState.OnDown:
                    buttonPressed = Input.GetButtonDown(buttonName.Value);
                    if (onlyAssignTrue && !buttonPressed) {
                        return;
                    }
                    variable.Value = buttonPressed;
                    break;
                case Constants.KeyState.OnCurrent:
                    buttonPressed = Input.GetButton(buttonName.Value);
                    if (onlyAssignTrue && !buttonPressed) {
                        return;
                    }
                    variable.Value = buttonPressed;
                    break;
                case Constants.KeyState.OnUp:
                    buttonPressed = Input.GetButtonUp(buttonName.Value);
                    if (onlyAssignTrue && !buttonPressed) {
                        return;
                    }
                    variable.Value = buttonPressed;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}