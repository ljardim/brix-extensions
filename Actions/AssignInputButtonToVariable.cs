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

        [Header("Outputs")]
        [SerializeField]private BoolReference variable;

        public override void Do() {
            switch (targetKeyState) {
                case Constants.KeyState.OnDown:
                    variable.Value = Input.GetButtonDown(buttonName.Value);
                    break;
                case Constants.KeyState.OnCurrent:
                    variable.Value = Input.GetButton(buttonName.Value);
                    break;
                case Constants.KeyState.OnUp:
                    variable.Value = Input.GetButtonUp(buttonName.Value);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}