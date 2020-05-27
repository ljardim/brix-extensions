using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Solve Foot IK")]
    public class SolveFootIK : AtomAction {
        [SerializeField]private LayerMask ignoreLayers;
        [SerializeField]private AvatarIKGoal ikGoal;
        [SerializeField]private StringReference targetAnimCurve;
        [SerializeField]private FloatReference originOffset = new FloatReference(0.2f);
        [SerializeField]private FloatReference feetOffset = new FloatReference(0.1f);
        [SerializeField]private GameObjectReference target;

        public override void Do() {
            if (ikGoal != AvatarIKGoal.LeftFoot || ikGoal != AvatarIKGoal.RightFoot) {
                Debug.Log("SolveFootIk only supports IkGoals for LeftFoot and RightFoot");
                return;
            }

            var animator = target.Value.GetComponent<Animator>();
            if (animator == null) {
                animator = target.Value.GetComponentInChildren<Animator>();
            }
            
            if (animator == null) {
                Debug.Log("No Animator component on target GameObject");
                return;
            }

            var targetFoot = animator.GetBoneTransform(ikGoal == AvatarIKGoal.LeftFoot ? HumanBodyBones.LeftFoot : HumanBodyBones.RightFoot);

            var originTransform = targetFoot;

            var weight = animator.GetFloat(targetAnimCurve.Value);

            var origin = originTransform.position;
            origin.y += originOffset.Value;
            var direction = Vector3.down;

            var targetPosition = origin;
            if (Physics.Raycast(origin, direction, out var hit, 1, ~ignoreLayers)) {
                targetPosition = hit.point + (Vector3.up * feetOffset.Value);
            }

            animator.SetIKPositionWeight(ikGoal, weight);
            animator.SetIKPosition(ikGoal, targetPosition);
        }
    }
}