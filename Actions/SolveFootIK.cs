using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityAtoms.Brix;
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

        [SerializeField]private AnimatorReference animator;
        [SerializeField]private TransformReference targetFootTransform;

        public override void Do() {
            if (ikGoal != AvatarIKGoal.LeftFoot || ikGoal != AvatarIKGoal.RightFoot) {
                Debug.Log("SolveFootIk only supports IkGoals for LeftFoot and RightFoot");
                return;
            }

            var anim = animator.Value;
            var targetFoot = targetFootTransform.Value;

            var originTransform = targetFoot;

            var weight = anim.GetFloat(targetAnimCurve.Value);

            var origin = originTransform.position;
            origin.y += originOffset.Value;
            var direction = Vector3.down;

            var targetPosition = origin;
            if (Physics.Raycast(origin, direction, out var hit, 1, ~ignoreLayers)) {
                targetPosition = hit.point + (Vector3.up * feetOffset.Value);
            }

            anim.SetIKPositionWeight(ikGoal, weight);
            anim.SetIKPosition(ikGoal, targetPosition);
        }
    }
}