using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Follow Transform")]
    public class FollowTransform : AtomAction {
        [Header("Inputs")]
        [SerializeField] [Tooltip("Follower GameObject to get Transform component from")]
        private GameObjectReference followerGameObject;
        [SerializeField] [Tooltip("Target GameObject to get Transform component from")]
        private GameObjectReference targetGameObject;

        [Header("Configuration")]
        [SerializeField]private FloatReference speed = new FloatReference(9);
        [SerializeField]private BoolReference isFixedUpdate;
        [SerializeField]private BoolReference shouldRunOnFixedUpdateVariable;

        public override void Do() {
            var source = followerGameObject.Value.transform;
            var target = targetGameObject.Value.transform;

            if (shouldRunOnFixedUpdateVariable != null) {
                if (isFixedUpdate.Value) {
                    if (!shouldRunOnFixedUpdateVariable.Value) {
                        return;
                    }
                } else {
                    if (shouldRunOnFixedUpdateVariable.Value) {
                        return;
                    }
                }
            }

            var t = speed.Value;
            if (isFixedUpdate.Value) {
                t *= Time.fixedDeltaTime;
            } else {
                t *= Time.deltaTime;
            }

            var fromPosition = source.position;
            var toPosition = target.position;
            source.position = Vector3.Lerp(fromPosition, toPosition, t);
        }
    }
}