// Gdk.Window.cs - Gdk Window class customizations
//
// Author: Moritz Balz <ich@mbalz.de>
//         Mike Kestner <mkestner@ximian.com>
//
// Copyright (c) 2003 Moritz Balz
// Copyright (c) 2004 - 2008 Novell, Inc.
//
// This code is inserted after the automatically generated code.
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.

namespace Gdk {

	using System;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

	public partial class Window {

		[DllImport ("libgdk-win32-3.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gdk_window_set_icon_list(IntPtr raw, IntPtr pixbufs);

		public Pixbuf[] IconList {
			set {
				GLib.List list = new GLib.List(IntPtr.Zero);
				foreach (Pixbuf val in value)
					list.Append (val.Handle);
				gdk_window_set_icon_list(Handle, list.Handle);
			}
		}
	}
}
