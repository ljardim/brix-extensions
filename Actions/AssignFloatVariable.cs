using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Assign Float Variable")]
    public class AssignFloatVariable : AtomAction {
        [SerializeField]private FloatReference input;
        [SerializeField]private FloatReference target;

        public override void Do() {
            target.Value = input.Value;
        }
    }
}