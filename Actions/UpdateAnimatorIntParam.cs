using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Update Animator Int Param")]
    public class UpdateAnimatorIntParam : AtomAction {
        [SerializeField]private GameObjectReference target;
        [SerializeField]private IntReference input;
        [SerializeField]private StringReference parameterName;

        public override void Do() {
            var animator = target.Value.GetComponent<Animator>();
            if (animator == null) {
                Debug.Log("No Animator component on target GameObject");
            } else {
                animator.SetInteger(parameterName.Value, input.Value);
            }
        }
    }
}