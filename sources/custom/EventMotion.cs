// Gdk.EventMotion.cs - Custom button motion wrapper 
//
// Author:  Mike Kestner <mkestner@novell.com>
//			Stephan Sundermann <stephansundermann@gmail.com>
//
// Copyright (c) 2004-2009 Novell, Inc.
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
	using System.Runtime.InteropServices;

	public partial class EventMotion {

		private partial struct NativeStruct {

			public double[] Axes {
				get {
					double[] result = null;
					if (_axes != IntPtr.Zero) {
						result = new double [Device.NAxes];
						Marshal.Copy (_axes, result, 0, result.Length);
					}
					return result;
				}
				set {
					if (_axes == IntPtr.Zero || value.Length != Device.NAxes)
						throw new InvalidOperationException ();
					Marshal.Copy (value, 0, _axes, value.Length);
				}
			}
		}

		public double[] Axes {
			get { return Native.Axes; }
			set { NativeStruct native = Native; native.Axes = value;  Marshal.StructureToPtr(native, this.Handle, false); }
		}
	}
}

