using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Trigger Animator Trigger Param")]
    public class TriggerAnimatorTriggerParam : AtomAction {
        [SerializeField]private GameObjectReference target;
        [SerializeField]private StringReference parameterName;

        public override void Do() {
            var animator = target.Value.GetComponent<Animator>();
            if (animator == null) {
                Debug.Log("No Animator component on target GameObject");
            } else {
                animator.SetTrigger(parameterName.Value);   
            }
        }
    }
}