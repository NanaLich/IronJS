﻿using System;
using IronJS.Runtime.Js;
using IronJS.Runtime.Utils;
using IronJS.Runtime.Js.Descriptors;

namespace IronJS.Runtime.Builtins
{
    class Math_obj_tan : NativeFunction
    {
        public Math_obj_tan(Context context)
            : base(context)
        {
            Set("length", new UserProperty(this, 1.0D));
        }

        public override object Call(IObj that, object[] args)
        {
            if (!HasArgs(args))
                throw new ArgumentException();

            return Math.Tan(JsTypeConverter.ToNumber(args[0]));
        }
    }
}