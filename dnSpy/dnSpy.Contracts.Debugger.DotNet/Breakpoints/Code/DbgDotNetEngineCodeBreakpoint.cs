﻿/*
    Copyright (C) 2014-2017 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using dnSpy.Contracts.Debugger.Breakpoints.Code;
using dnSpy.Contracts.Metadata;

namespace dnSpy.Contracts.Debugger.DotNet.Breakpoints.Code {
	/// <summary>
	/// .NET code breakpoint. It contains a weak module reference, a method token and
	/// an IL offset.
	/// </summary>
	public abstract class DbgDotNetEngineCodeBreakpoint : DbgEngineCodeBreakpoint {
		/// <summary>
		/// Gets the module
		/// </summary>
		public abstract ModuleId Module { get; }

		/// <summary>
		/// Gets the token of a method within the module
		/// </summary>
		public abstract uint Token { get; }

		/// <summary>
		/// Gets the IL offset of the breakpoint within the method body
		/// </summary>
		public abstract uint Offset { get; }
	}
}