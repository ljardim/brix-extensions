using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-sand")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Assign Anim Bool To Variable")]
    public class AssignAnimBoolToVariable : AtomAction {
        [SerializeField] [Tooltip("Target GameObject to get Animator component from")]
        private GameObjectReference gameObject;
        [SerializeField]private StringReference inputAnimName;
        [SerializeField]private BoolReference target;

        public override void Do() {
            var animator = gameObject.Value.GetComponent<Animator>();
            if (animator == null) {
                animator = gameObject.Value.GetComponentInChildren<Animator>();
            }
            
            if (animator != null) {
                target.Value = animator.GetBool(inputAnimName.Value);
            } else {
                Debug.Log("Target GameObject does not have an Animator component");
            }
        }
    }
}