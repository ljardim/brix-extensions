using Brix.State;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [CreateAssetMenu(menuName = Constants.Menus.CONDITIONS + "Animator Bool Check")]
    public class AnimatorBoolCheck : Condition {
        [SerializeField]private GameObjectReference player;
        [SerializeField]private StringReference animatorBoolParamName;
        [SerializeField]private BoolReference expectedValue;
        public override bool CheckCondition() {
            var animator = player.Value.GetComponent<Animator>();
            if (animator != null) {
                return animator.GetBool(animatorBoolParamName.Value).Equals(expectedValue.Value);
            }

            animator = player.Value.GetComponentInChildren<Animator>();
            if (animator != null) {
                return animator.GetBool(animatorBoolParamName.Value).Equals(expectedValue.Value);
            }

            Debug.Log("Target Player GameObject does not have an Animator component");
            return false;

        }
    }
}