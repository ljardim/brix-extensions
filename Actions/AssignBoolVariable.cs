using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Assign Bool Variable")]
    public class AssignBoolVariable : AtomAction {
        [SerializeField]private BoolReference input;
        [SerializeField]private BoolReference target;

        public override void Do() {
            target.Value = input.Value;
        }
    }
}