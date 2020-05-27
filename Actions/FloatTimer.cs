using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Float Timer")]
    public class FloatTimer : AtomAction {
        [SerializeField]private FloatVariable timer;
        
        public override void Do() {
            timer.Value += Time.fixedDeltaTime;
        }
    }
}