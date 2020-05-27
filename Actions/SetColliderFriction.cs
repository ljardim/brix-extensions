using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Set Collider Friction")]
    public class SetColliderFriction : AtomAction {
        [SerializeField]private GameObjectReference player;
        [SerializeField]private FloatReference dynamicFriction;
        [SerializeField]private FloatReference staticFriction;

        public override void Do() {
            var collider = player.Value.GetComponent<Collider>();
            if (collider == null) {
                Debug.Log("Player GameObject does not have a Collider component");
                return;
            }

            collider.material.staticFriction = staticFriction.Value;
            collider.material.dynamicFriction = dynamicFriction.Value;
        }
    }
}