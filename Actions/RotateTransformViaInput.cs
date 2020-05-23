using System;
using UnityAtoms;
using UnityAtoms.BaseAtoms;
using UnityEngine;

namespace Brix.Extensions {
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = Constants.Menus.ACTIONS + "Rotate Transform Based On Float")]
    public class RotateTransformViaInput : AtomAction {
        [Header("Input Params")]
        [SerializeField]private Constants.Axis targetAxis;
        [SerializeField]private GameObjectReference transformToRotateGameObject;
        [SerializeField]private FloatReference inputRotationFloat;
        
        [Header("Configuration")]
        [SerializeField]private FloatReference rotationSpeed = new FloatReference(9);
        [SerializeField]private BoolReference shouldClamp = new BoolReference(false);
        [SerializeField]private FloatReference clampMax = new FloatReference(35);
        [SerializeField]private FloatReference clampMin = new FloatReference(-35);
        [SerializeField]private BoolReference invert = new BoolReference(false);
        
        private float _angle;

        public override void Do() {
            var transform = transformToRotateGameObject.Value.transform;
            var targetSpeed = Time.deltaTime * rotationSpeed.Value;

            _angle = invert.Value
                ? Mathf.Lerp(_angle, _angle - inputRotationFloat.Value, targetSpeed)
                : Mathf.Lerp(_angle, _angle + inputRotationFloat.Value, targetSpeed);

            if (shouldClamp.Value) {
                _angle = Mathf.Clamp(_angle, clampMin.Value, clampMax.Value);
            }

            switch (targetAxis) {
                case Constants.Axis.X:
                    transform.localRotation = Quaternion.Euler(_angle, 0, 0);
                    break;
                case Constants.Axis.Y:
                    transform.localRotation = Quaternion.Euler(0, _angle, 0);
                    break;
                case Constants.Axis.Z:
                    transform.localRotation = Quaternion.Euler(0, 0, _angle);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}