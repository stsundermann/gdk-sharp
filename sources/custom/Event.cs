// Gdk.Event.cs - Custom event wrapper 
//
// Authors: Rachel Hestilow <hestilow@ximian.com> 
//          Mike Kestner <mkestner@novell.com>
//			Stephan Sundermann <stephansundermann@gmail.com>
//
// Copyright (c) 2002 Rachel Hestilow
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

	public partial class Event {

		public static Event GetEvent (IntPtr raw)
		{
			if (raw == IntPtr.Zero)
				return null;

			NativeStruct native = (NativeStruct) Marshal.PtrToStructure (raw, typeof(NativeStruct));
			switch (native.Type) {
			case EventType.Expose:
				return new EventExpose (raw);
			case EventType.MotionNotify:
				return new EventMotion (raw);
			case EventType.ButtonPress:
			case EventType.TwoButtonPress:
			case EventType.ThreeButtonPress:
			case EventType.ButtonRelease:
				return new EventButton (raw);
			case EventType.KeyPress:
			case EventType.KeyRelease:
				return new EventKey (raw);
			case EventType.EnterNotify:
			case EventType.LeaveNotify:
				return new EventCrossing (raw);
			case EventType.FocusChange:
				return new EventFocus (raw);
			case EventType.Configure:
				return new EventConfigure (raw);
			case EventType.PropertyNotify:
				return new EventProperty (raw);
			case EventType.SelectionClear:
			case EventType.SelectionRequest:
			case EventType.SelectionNotify:
				return new EventSelection (raw);
			case EventType.ProximityIn:
			case EventType.ProximityOut:
				return new EventProximity (raw);
			case EventType.DragEnter:
			case EventType.DragLeave:
			case EventType.DragMotion:
			case EventType.DragStatus:
			case EventType.DropStart:
			case EventType.DropFinished:
				return new EventDND (raw);
			case EventType.VisibilityNotify:
				return new EventVisibility (raw);
			case EventType.Scroll:
				return new EventScroll (raw);
			case EventType.WindowState:
				return new EventWindowState (raw);
			case EventType.Setting:
				return new EventSetting (raw);
			case EventType.OwnerChange:
				return new EventOwnerChange (raw);
			case EventType.GrabBroken:
				return new EventGrabBroken (raw);
			case EventType.Map:
			case EventType.Unmap:
			case EventType.Delete:
			case EventType.Destroy:
			default:
				return new Gdk.Event (raw);
			}
		}
	}
}

