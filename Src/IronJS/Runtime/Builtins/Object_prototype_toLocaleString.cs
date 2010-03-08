﻿using IronJS.Runtime.Js;
using IronJS.Runtime.Js.Descriptors;

namespace IronJS.Runtime.Builtins
{
    class Object_prototype_toLocaleString : NativeFunction
    {
        public Object_prototype_toLocaleString(Context context)
            : base(context)
        {
            this.Set("length", 0);
        }

        public override object Call(IObj that, object[] args)
        {
            return (that.Search("toString") as IFunction).Call(that, args);
        }
    }
}