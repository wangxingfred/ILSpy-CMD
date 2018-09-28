﻿using ICSharpCode.NRefactory.CSharp;
using System.Linq;

namespace ICSharpCode.Decompiler.Ast.Transforms
{
	internal class FlattenSwitchBlocks : IAstTransform
	{
		public void Run(AstNode compilationUnit)
		{
			foreach (var switchSection in compilationUnit.Descendants.OfType<SwitchSection>())
			{
				if (switchSection.Statements.Count != 1)
					continue;

				var blockStatement = switchSection.Statements.First() as BlockStatement;
				if (blockStatement == null || blockStatement.Statements.Any(st => st is VariableDeclarationStatement))
					continue;

				blockStatement.Remove();
				blockStatement.Statements.MoveTo(switchSection.Statements);
			}
		}
	}
}