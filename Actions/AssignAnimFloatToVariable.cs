using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Assign Anim Float To Variable")]
    public class AssignAnimFloatToVariable : AtomAction {
        [SerializeField] [Tooltip("Target GameObject to get Animator component from")]
        private GameObjectReference gameObject;
        [SerializeField]private StringReference inputAnimName;
        [SerializeField]private FloatReference target;

        public override void Do() {
            var animator = gameObject.Value.GetComponent<Animator>();
            if (animator != null) {
                target.Value = animator.GetFloat(inputAnimName.Value);
            } else {
                Debug.Log("Target GameObject does not have an Animator component");
            }
        }
    }
}