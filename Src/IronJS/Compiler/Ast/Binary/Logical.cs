﻿using System;
using System.Text;
using Antlr.Runtime.Tree;
using IronJS.Runtime2.Js;

#if CLR2
using Microsoft.Scripting.Ast;
using System.Collections.Generic;
#else
using System.Linq.Expressions;
#endif

namespace IronJS.Compiler.Ast {
	public class Logical : Node {
		public INode Left { get { return Children[0]; } }
		public INode Right { get { return Children[1]; } }
		public ExpressionType Op { get; protected set; }

		public Logical(INode left, INode right, ExpressionType op, ITree node)
			: base(NodeType.Logical, node) {
			Op = op;
			Children = new[] { left, right };
		}

		public override Type Type {
			get {
				if (Left.Type == Right.Type)
					return Left.Type;

				return IjsTypes.Dynamic;
			}
		}
	}
}