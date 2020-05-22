using ScriptableObjectArchitecture;
using SOA.Common;
using UnityEngine;

namespace Brix.Extensions {
    [FileIcon("brix-icon-action")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Solve Foot IK")]
    public class SolveFootIK : Action {
        [SerializeField]private LayerMask ignoreLayers;
        [SerializeField]private AvatarIKGoal ikGoal;
        [SerializeField]private StringReference targetAnimCurve;
        [SerializeField]private FloatReference originOffset = new FloatReference(0.2f);
        [SerializeField]private FloatReference feetOffset = new FloatReference(0.1f);

        [SerializeField]private ObjectReference animator;
        [SerializeField]private ObjectReference targetFootTransform;

        public override void Execute() {
            if (ikGoal != AvatarIKGoal.LeftFoot || ikGoal != AvatarIKGoal.RightFoot) {
                Debug.Log("SolveFootIk only supports IkGoals for LeftFoot and RightFoot");
                return;
            }
            if (!(animator.Value is Animator) || !(targetFootTransform.Value is Transform)) {
                Debug.Log("SolveFootIk animator reference should be an Animator and Target Foot Transform should be Transform references but one of them are not");
                return;
            }

            var anim = (Animator) animator.Value;
            var targetFoot = (Transform) targetFootTransform.Value;

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