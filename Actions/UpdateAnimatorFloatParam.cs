using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Update Animator Float Param")]
    public class UpdateAnimatorFloatParam : AtomAction {
        [SerializeField]private GameObjectReference target;
        [SerializeField]private FloatReference input;
        [SerializeField]private StringReference parameterName;
        [SerializeField]private BoolReference useMultiplier = new BoolReference(false);
        [SerializeField]private FloatReference multiplier = new FloatReference(1f);

        private float _lerpValue;
        
        public override void Do() {
            var animator = target.Value.GetComponent<Animator>();
            if (animator == null) {
                animator = target.Value.GetComponentInChildren<Animator>();
                if (animator == null) {
                    Debug.Log("No Animator component on target GameObject");
                    return;
                }
            }

            var speed = useMultiplier ? multiplier.Value : 1f;
            _lerpValue = Mathf.Lerp(_lerpValue, speed * input.Value, 5 * Time.deltaTime);
            animator.SetFloat(parameterName.Value, _lerpValue);
        }
    }
}