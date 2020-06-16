﻿// Copyright (c) 2011 AlphaSierraPapa for the SharpDevelop Team
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using ICSharpCode.NRefactory.CSharp;
using System;
using System.ComponentModel;

namespace ICSharpCode.Decompiler
{
	/// <summary>
	/// Settings for the decompiler.
	/// </summary>
	public class DecompilerSettings : INotifyPropertyChanged
	{
		private bool anonymousMethods = true;

		/// <summary>
		/// Decompile anonymous methods/lambdas.
		/// </summary>
		public bool AnonymousMethods
		{
			get { return anonymousMethods; }
			set
			{
				if (anonymousMethods != value)
				{
					anonymousMethods = value;
					OnPropertyChanged("AnonymousMethods");
				}
			}
		}

		private bool expressionTrees = true;

		/// <summary>
		/// Decompile expression trees.
		/// </summary>
		public bool ExpressionTrees
		{
			get { return expressionTrees; }
			set
			{
				if (expressionTrees != value)
				{
					expressionTrees = value;
					OnPropertyChanged("ExpressionTrees");
				}
			}
		}

		private bool yieldReturn = true;

		/// <summary>
		/// Decompile enumerators.
		/// </summary>
		public bool YieldReturn
		{
			get { return yieldReturn; }
			set
			{
				if (yieldReturn != value)
				{
					yieldReturn = value;
					OnPropertyChanged("YieldReturn");
				}
			}
		}

		private bool asyncAwait = true;

		/// <summary>
		/// Decompile async methods.
		/// </summary>
		public bool AsyncAwait
		{
			get { return asyncAwait; }
			set
			{
				if (asyncAwait != value)
				{
					asyncAwait = value;
					OnPropertyChanged("AsyncAwait");
				}
			}
		}

		private bool automaticProperties = true;

		/// <summary>
		/// Decompile automatic properties
		/// </summary>
		public bool AutomaticProperties
		{
			get { return automaticProperties; }
			set
			{
				if (automaticProperties != value)
				{
					automaticProperties = value;
					OnPropertyChanged("AutomaticProperties");
				}
			}
		}

		private bool automaticEvents = true;

		/// <summary>
		/// Decompile automatic events
		/// </summary>
		public bool AutomaticEvents
		{
			get { return automaticEvents; }
			set
			{
				if (automaticEvents != value)
				{
					automaticEvents = value;
					OnPropertyChanged("AutomaticEvents");
				}
			}
		}

		private bool usingStatement = true;

		/// <summary>
		/// Decompile using statements.
		/// </summary>
		public bool UsingStatement
		{
			get { return usingStatement; }
			set
			{
				if (usingStatement != value)
				{
					usingStatement = value;
					OnPropertyChanged("UsingStatement");
				}
			}
		}

		private bool forEachStatement = true;

		/// <summary>
		/// Decompile foreach statements.
		/// </summary>
		public bool ForEachStatement
		{
			get { return forEachStatement; }
			set
			{
				if (forEachStatement != value)
				{
					forEachStatement = value;
					OnPropertyChanged("ForEachStatement");
				}
			}
		}

		private bool lockStatement = true;

		/// <summary>
		/// Decompile lock statements.
		/// </summary>
		public bool LockStatement
		{
			get { return lockStatement; }
			set
			{
				if (lockStatement != value)
				{
					lockStatement = value;
					OnPropertyChanged("LockStatement");
				}
			}
		}

		private bool switchStatementOnString = true;

		public bool SwitchStatementOnString
		{
			get { return switchStatementOnString; }
			set
			{
				if (switchStatementOnString != value)
				{
					switchStatementOnString = value;
					OnPropertyChanged("SwitchStatementOnString");
				}
			}
		}

		private bool usingDeclarations = true;

		public bool UsingDeclarations
		{
			get { return usingDeclarations; }
			set
			{
				if (usingDeclarations != value)
				{
					usingDeclarations = value;
					OnPropertyChanged("UsingDeclarations");
				}
			}
		}

		private bool queryExpressions = true;

		public bool QueryExpressions
		{
			get { return queryExpressions; }
			set
			{
				if (queryExpressions != value)
				{
					queryExpressions = value;
					OnPropertyChanged("QueryExpressions");
				}
			}
		}

		private bool fullyQualifyAmbiguousTypeNames = true;

		public bool FullyQualifyAmbiguousTypeNames
		{
			get { return fullyQualifyAmbiguousTypeNames; }
			set
			{
				if (fullyQualifyAmbiguousTypeNames != value)
				{
					fullyQualifyAmbiguousTypeNames = value;
					OnPropertyChanged("FullyQualifyAmbiguousTypeNames");
				}
			}
		}

		private bool useDebugSymbols = true;

		/// <summary>
		/// Gets/Sets whether to use variable names from debug symbols, if available.
		/// </summary>
		public bool UseDebugSymbols
		{
			get { return useDebugSymbols; }
			set
			{
				if (useDebugSymbols != value)
				{
					useDebugSymbols = value;
					OnPropertyChanged("UseDebugSymbols");
				}
			}
		}

		private bool objectCollectionInitializers = true;

		/// <summary>
		/// Gets/Sets whether to use C# 3.0 object/collection initializers
		/// </summary>
		public bool ObjectOrCollectionInitializers
		{
			get { return objectCollectionInitializers; }
			set
			{
				if (objectCollectionInitializers != value)
				{
					objectCollectionInitializers = value;
					OnPropertyChanged("ObjectCollectionInitializers");
				}
			}
		}

		private bool showXmlDocumentation = true;

		/// <summary>
		/// Gets/Sets whether to include XML documentation comments in the decompiled code
		/// </summary>
		public bool ShowXmlDocumentation
		{
			get { return showXmlDocumentation; }
			set
			{
				if (showXmlDocumentation != value)
				{
					showXmlDocumentation = value;
					OnPropertyChanged("ShowXmlDocumentation");
				}
			}
		}

		private bool foldBraces = false;

		public bool FoldBraces
		{
			get { return foldBraces; }
			set
			{
				if (foldBraces != value)
				{
					foldBraces = value;
					OnPropertyChanged("FoldBraces");
				}
			}
		}

		private bool withMvid = true;
		public bool WithMvid
		{
			get { return withMvid; }
			set
			{
				if (withMvid != value)
				{
					withMvid = value;
					OnPropertyChanged("withMVID");
				}
			}
		}

		#region Options to aid VB decompilation

		private bool introduceIncrementAndDecrement = true;

		/// <summary>
		/// Gets/Sets whether to use increment and decrement operators
		/// </summary>
		public bool IntroduceIncrementAndDecrement
		{
			get { return introduceIncrementAndDecrement; }
			set
			{
				if (introduceIncrementAndDecrement != value)
				{
					introduceIncrementAndDecrement = value;
					OnPropertyChanged("IntroduceIncrementAndDecrement");
				}
			}
		}

		private bool makeAssignmentExpressions = true;

		/// <summary>
		/// Gets/Sets whether to use assignment expressions such as in while ((count = Do()) != 0) ;
		/// </summary>
		public bool MakeAssignmentExpressions
		{
			get { return makeAssignmentExpressions; }
			set
			{
				if (makeAssignmentExpressions != value)
				{
					makeAssignmentExpressions = value;
					OnPropertyChanged("MakeAssignmentExpressions");
				}
			}
		}

		private bool alwaysGenerateExceptionVariableForCatchBlocks = false;

		/// <summary>
		/// Gets/Sets whether to always generate exception variables in catch blocks
		/// </summary>
		public bool AlwaysGenerateExceptionVariableForCatchBlocks
		{
			get { return alwaysGenerateExceptionVariableForCatchBlocks; }
			set
			{
				if (alwaysGenerateExceptionVariableForCatchBlocks != value)
				{
					alwaysGenerateExceptionVariableForCatchBlocks = value;
					OnPropertyChanged("AlwaysGenerateExceptionVariableForCatchBlocks");
				}
			}
		}

		#endregion Options to aid VB decompilation

		private CSharpFormattingOptions csharpFormattingOptions;

		public CSharpFormattingOptions CSharpFormattingOptions
		{
			get
			{
				if (csharpFormattingOptions == null)
				{
					csharpFormattingOptions = FormattingOptionsFactory.CreateAllman();
					csharpFormattingOptions.IndentSwitchBody = false;
					csharpFormattingOptions.ArrayInitializerWrapping = Wrapping.WrapAlways;
				}
				return csharpFormattingOptions;
			}
			set
			{
				if (value == null)
					throw new ArgumentNullException();
				if (csharpFormattingOptions != value)
				{
					csharpFormattingOptions = value;
					OnPropertyChanged("CSharpFormattingOptions");
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public DecompilerSettings Clone()
		{
			DecompilerSettings settings = (DecompilerSettings)MemberwiseClone();
			if (csharpFormattingOptions != null)
				settings.csharpFormattingOptions = csharpFormattingOptions.Clone();
			settings.PropertyChanged = null;
			return settings;
		}
	}
}