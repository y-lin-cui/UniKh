﻿/** StandardEase.cs
 *  Author:         bagaking <kinghand@foxmail.com>
 *  CreateTime:     2019/10/17 11:59:29
 *  Copyright:      (C) 2019 - 2029 bagaking, All Rights Reserved
 */

using System;
using UnityEngine;

namespace UniKh.core.tween {
    public class EaseDetailAttribute : PropertyAttribute {
        public readonly bool showMotion = false;
        public EaseDetailAttribute() { }

        public EaseDetailAttribute(bool showMotion) {
            this.showMotion = showMotion;
        }
    }

    public static class StandardEase {
        public enum Type {
            Linear = 1,
            InSine,
            OutSine,
            InOutSine,
            InQuad,
            OutQuad,
            InOutQuad,
            InCubic,
            OutCubic,
            InOutCubic,
            InQuart,
            OutQuart,
            InOutQuart,
            InQuint,
            OutQuint,
            InOutQuint,
            InExpo,
            OutExpo,
            InOutExpo,
        }

        public static Easing Get(Type type) {
            switch (type) {
                case Type.Linear:
                    return EaseLinear.Default;
                case Type.InSine:
                    return EaseSine.DefaultIn;
                case Type.OutSine:
                    return EaseSine.DefaultOut;
                case Type.InOutSine:
                    return EaseSine.DefaultInOut;
                case Type.InQuad:
                    return EaseQuad.DefaultIn;
                case Type.OutQuad:
                    return EaseQuad.DefaultOut;
                case Type.InOutQuad:
                    return EaseQuad.DefaultInOut;
                case Type.InCubic:
                    return EaseCubic.DefaultIn;
                case Type.OutCubic:
                    return EaseCubic.DefaultOut;
                case Type.InOutCubic:
                    return EaseCubic.DefaultInOut;
                case Type.InQuart:
                    return EaseQuart.DefaultIn;
                case Type.OutQuart:
                    return EaseQuart.DefaultOut;
                case Type.InOutQuart:
                    return EaseQuart.DefaultInOut;
                case Type.InQuint:
                    return EaseQuint.DefaultIn;
                case Type.OutQuint:
                    return EaseQuint.DefaultOut;
                case Type.InOutQuint:
                    return EaseQuint.DefaultInOut;
                case Type.InExpo:
                    return EaseExpo.DefaultIn;
                case Type.OutExpo:
                    return EaseExpo.DefaultOut;
                case Type.InOutExpo:
                    return EaseExpo.DefaultInOut;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}