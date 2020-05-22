using Brix.State;
using UnityEngine;

namespace Brix.Extensions {
    [CreateAssetMenu(menuName = Constants.Menus.CONDITIONS + "Multi Condition")]
    public abstract class MultiCondition : Condition {
        [SerializeField]private Condition[] conditions;
        
        public override bool CheckCondition() {
            var finalValue = true;
            foreach (var condition in conditions) {
                finalValue = finalValue && condition.CheckCondition();
            }
            return finalValue;
        }
    }
}