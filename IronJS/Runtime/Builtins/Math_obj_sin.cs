﻿using System;
using IronJS.Runtime.Js;
using IronJS.Runtime.Utils;
using IronJS.Runtime.Js.Descriptors;

namespace IronJS.Runtime.Builtins
{
    class Math_obj_sin : NativeFunction
    {
        public Math_obj_sin(Context context)
            : base(context)
        {
            Set("length", new UserProperty(this, 1.0D));
        }

        public override object Call(IObj that, object[] args)
        {
            if (!HasArgs(args))
                throw new ArgumentException();

            return Math.Sin(JsTypeConverter.ToNumber(args[0]));
        }
    }
}