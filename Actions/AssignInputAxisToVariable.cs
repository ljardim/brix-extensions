using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Assign Input Axis To Variable")]
    public class AssignInputAxisToVariable : AtomAction {
        [SerializeField]private StringReference axisName;
        [SerializeField]private FloatReference variable;

        public override void Do() {
            variable.Value = Input.GetAxis(axisName.Value);
        }
    }
}