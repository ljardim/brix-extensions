﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Brix.Extensions {
    public static class Constants {
        public enum Axis {
            X,
            Y,
            Z
        }

        public enum Direction {
            Forward,
            Backward,
            Left,
            Right,
            Down,
            Up
        }
        
        public enum Comparison {
            Equals,
            NotEquals,
            GreaterThan,
            GreaterThanEquals,
            LessThan,
            LessThanEquals
        }
        
        public enum Operator {
            And,
            Or
        }

        public enum KeyState {
            OnDown,
            OnCurrent,
            OnUp
        }

        public enum PhysicsCastType {
            SingleRayCast,
            SphereCast
        }

        public static readonly Dictionary<Direction, Vector3> DirectionMap = new Dictionary<Direction, Vector3> {
            {Direction.Backward, Vector3.back},
            {Direction.Forward, Vector3.forward},
            {Direction.Left, Vector3.left},
            {Direction.Right, Vector3.right},
            {Direction.Up, Vector3.up},
            {Direction.Down, Vector3.down}
        };

        public static class Menus {
            public const string ROOT = "Brix/";
            public const string STATE = ROOT + "State/";
            public const string ACTIONS = ROOT + "Actions/";
            public const string VARIABLES = ROOT + "Variables/";
            public const string CONDITIONS = ROOT + "Conditions/";
        }
    }
}