﻿using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using WindowsFirewallHelper.Helpers;

namespace WindowsFirewallHelper.COMInterop
{
    [Guid("79649BB4-903E-421B-94C9-79848E79F6EE")]
    [ComImport]
    internal interface INetFwServices : IEnumerable
    {
        [DispId(1)]
        int Count
        {
            [DispId(1)]
            [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
            get;
        }

        [DispId(2)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.Interface)]
        INetFwService Item([In] NET_FW_SERVICE_TYPE svcType);

        [DispId(-4)]
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(EnumeratorToEnumVariantMarshaler))]
        new IEnumerator GetEnumerator();
    }
}