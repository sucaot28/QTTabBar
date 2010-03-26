//    This file is part of QTTabBar, a shell extension for Microsoft
//    Windows Explorer.
//    Copyright (C) 2010  Paul Accisano
//
//    QTTabBar is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    QTTabBar is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with QTTabBar.  If not, see <http://www.gnu.org/licenses/>.

namespace QTTabBarLib.Interop {
    using BandObjectLib;
    using System;
    using System.Runtime.InteropServices;
    using System.Security;

    [ComImport, Guid("000214E3-0000-0000-C000-000000000046"), SuppressUnmanagedCodeSecurity, InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IShellView {
        void GetWindow(out IntPtr phwnd);
        void ContextSensitiveHelp(bool fEnterMode);
        void TranslateAccelerator(ref MSG pmsg);
        void EnableModeless(bool fEnable);
        void UIActivate(uint uState);
        void Refresh();
        [PreserveSig]
        int CreateViewWindow(IShellView psvPrevious, ref FOLDERSETTINGS lpfs, IShellBrowser psb, ref RECT prcView, out IntPtr phWnd);
        void DestroyViewWindow();
        [PreserveSig]
        int GetCurrentInfo(ref FOLDERSETTINGS lpfs);
        void AddPropertySheetPages(int dwReserved, IntPtr pfn, IntPtr lparam);
        [PreserveSig]
        int SaveViewState();
        [PreserveSig]
        int SelectItem(IntPtr pidlItem, uint uFlags);
        void GetItemObject(uint uItem, ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
    }
}