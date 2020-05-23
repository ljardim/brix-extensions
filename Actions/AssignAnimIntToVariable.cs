using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Assign Anim Int To Variable")]
    public class AssignAnimIntToVariable : AtomAction {
        [SerializeField] [Tooltip("Target GameObject to get Animator component from")]
        private GameObjectReference gameObject;
        [SerializeField]private StringReference inputAnimName;
        [SerializeField]private IntReference target;

        public override void Do() {
            var animator = gameObject.Value.GetComponent<Animator>();
            if (animator != null) {
                target.Value = animator.GetInteger(inputAnimName.Value);
            } else {
                Debug.Log("Target GameObject does not have an Animator component");
            }
        }
    }
}