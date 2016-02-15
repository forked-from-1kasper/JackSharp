﻿// Author:
//       Thomas Mayer <thomas@residuum.org>
//
// Copyright (c) 2016 Thomas Mayer
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;
using System.Runtime.InteropServices;
using JackSharp.Pointers;

namespace JackSharp.ApiWrapper
{
	static class PortCallbackApi
	{
		[DllImport (Constants.JACK_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		public static extern unsafe int jack_set_client_registration_callback (UnsafeStructs.jack_client_t* client, Callbacks.JackClientRegistrationCallback registrationCallback, IntPtr arg);

		[DllImport (Constants.JACK_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		public static extern unsafe int jack_set_port_registration_callback (UnsafeStructs.jack_client_t* client, Callbacks.JackPortRegistrationCallback registrationCallback, IntPtr arg);

		[DllImport (Constants.JACK_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		public static extern unsafe int jack_set_port_rename_callback (UnsafeStructs.jack_client_t* client, Callbacks.JackPortRenameCallback renameCallback, IntPtr arg);

		[DllImport (Constants.JACK_LIB_NAME, CallingConvention = CallingConvention.Cdecl)]
		public static extern unsafe int jack_set_port_connect_callback (UnsafeStructs.jack_client_t* client, Callbacks.JackPortConnectCallback connectCallback, IntPtr arg);
	}
}