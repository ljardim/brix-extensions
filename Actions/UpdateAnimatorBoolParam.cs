using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Update Animator Bool Param")]
    public class UpdateAnimatorBoolParam : AtomAction {
        [SerializeField]private GameObjectReference target;
        [SerializeField]private BoolReference input;
        [SerializeField]private StringReference parameterName;

        public override void Do() {
            var animator = target.Value.GetComponent<Animator>();
            if (animator == null) {
                animator = target.Value.GetComponentInChildren<Animator>();
            }
            
            if (animator == null) {
                Debug.Log("No Animator component on target GameObject");
            } else {
                animator.SetBool(parameterName.Value, input.Value);
            }
        }
    }
}