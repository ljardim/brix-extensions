using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Play Animator Anim")]
    public class PlayerAnimatorAnim : AtomAction {
        [SerializeField]private GameObjectReference player;
        [SerializeField]private StringReference animName;

        public override void Do() {
            var animator = player.Value.GetComponent<Animator>();
            if (animator == null) {
                animator = player.Value.GetComponentInChildren<Animator>();
                if (animator == null) {
                    Debug.Log("Target Player GameObject does not have an Animator component");
                    return;
                }
            }
            
            animator.Play(animName.Value);
        }
    }
}