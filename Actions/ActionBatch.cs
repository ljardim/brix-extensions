using UnityAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Batch Action Runner")]
    public class ActionBatch : AtomAction {
        [SerializeField]private AtomAction[] actions;

        public override void Do() {
            foreach (var action in actions) {
                action.Do();
            }
        }
    }
}