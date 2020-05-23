using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Assign Int Variable")]
    public class AssignIntVariable : AtomAction {
        [SerializeField]private IntReference input;
        [SerializeField]private IntReference target;

        public override void Do() {
            target.Value = input.Value;
        }
    }
}