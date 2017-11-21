// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace VideoLAN.LibVLC
{
    /// <summary>
    /// <para>@{</para>
    /// <para></para>
    /// <para>LibVLC media library external API</para>
    /// </summary>
    public unsafe partial class LibvlcMediaLibraryT
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.LibvlcMediaLibraryT> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.LibvlcMediaLibraryT>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::VideoLAN.LibVLC.LibvlcMediaLibraryT __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::VideoLAN.LibVLC.LibvlcMediaLibraryT(native.ToPointer(), skipVTables);
        }

        internal static global::VideoLAN.LibVLC.LibvlcMediaLibraryT __CreateInstance(global::VideoLAN.LibVLC.LibvlcMediaLibraryT.__Internal native, bool skipVTables = false)
        {
            return new global::VideoLAN.LibVLC.LibvlcMediaLibraryT(native, skipVTables);
        }

        private static void* __CopyValue(global::VideoLAN.LibVLC.LibvlcMediaLibraryT.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::VideoLAN.LibVLC.LibvlcMediaLibraryT.__Internal));
            *(global::VideoLAN.LibVLC.LibvlcMediaLibraryT.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private LibvlcMediaLibraryT(global::VideoLAN.LibVLC.LibvlcMediaLibraryT.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected LibvlcMediaLibraryT(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class libvlc_media_library
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_library_new")]
            internal static extern global::System.IntPtr LibvlcMediaLibraryNew(global::System.IntPtr p_instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_library_release")]
            internal static extern void LibvlcMediaLibraryRelease(global::System.IntPtr p_mlib);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_library_retain")]
            internal static extern void LibvlcMediaLibraryRetain(global::System.IntPtr p_mlib);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_library_load")]
            internal static extern int LibvlcMediaLibraryLoad(global::System.IntPtr p_mlib);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_library_media_list")]
            internal static extern global::System.IntPtr LibvlcMediaLibraryMediaList(global::System.IntPtr p_mlib);
        }

        /// <summary>Create an new Media Library object</summary>
        /// <param name="p_instance">the libvlc instance</param>
        /// <returns>a new object or NULL on error</returns>
        public static global::VideoLAN.LibVLC.LibvlcMediaLibraryT LibvlcMediaLibraryNew(global::VideoLAN.LibVLC.Instance p_instance)
        {
            var __arg0 = ReferenceEquals(p_instance, null) ? global::System.IntPtr.Zero : p_instance.NativeReference;
            var __ret = __Internal.LibvlcMediaLibraryNew(__arg0);
            global::VideoLAN.LibVLC.LibvlcMediaLibraryT __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::VideoLAN.LibVLC.LibvlcMediaLibraryT.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::VideoLAN.LibVLC.LibvlcMediaLibraryT) global::VideoLAN.LibVLC.LibvlcMediaLibraryT.NativeToManagedMap[__ret];
            else __result0 = global::VideoLAN.LibVLC.LibvlcMediaLibraryT.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>
        /// <para>Release media library object. This functions decrements the</para>
        /// <para>reference count of the media library object. If it reaches 0,</para>
        /// <para>then the object will be released.</para>
        /// </summary>
        /// <param name="p_mlib">media library object</param>
        public static void LibvlcMediaLibraryRelease(global::VideoLAN.LibVLC.LibvlcMediaLibraryT p_mlib)
        {
            var __arg0 = ReferenceEquals(p_mlib, null) ? global::System.IntPtr.Zero : p_mlib.__Instance;
            __Internal.LibvlcMediaLibraryRelease(__arg0);
        }

        /// <summary>
        /// <para>Retain a reference to a media library object. This function will</para>
        /// <para>increment the reference counting for this object. Use</para>
        /// <para>libvlc_media_library_release() to decrement the reference count.</para>
        /// </summary>
        /// <param name="p_mlib">media library object</param>
        public static void LibvlcMediaLibraryRetain(global::VideoLAN.LibVLC.LibvlcMediaLibraryT p_mlib)
        {
            var __arg0 = ReferenceEquals(p_mlib, null) ? global::System.IntPtr.Zero : p_mlib.__Instance;
            __Internal.LibvlcMediaLibraryRetain(__arg0);
        }

        /// <summary>Load media library.</summary>
        /// <param name="p_mlib">media library object</param>
        /// <returns>0 on success, -1 on error</returns>
        public static int LibvlcMediaLibraryLoad(global::VideoLAN.LibVLC.LibvlcMediaLibraryT p_mlib)
        {
            var __arg0 = ReferenceEquals(p_mlib, null) ? global::System.IntPtr.Zero : p_mlib.__Instance;
            var __ret = __Internal.LibvlcMediaLibraryLoad(__arg0);
            return __ret;
        }

        /// <summary>Get media library subitems.</summary>
        /// <param name="p_mlib">media library object</param>
        /// <returns>media list subitems</returns>
        public static global::VideoLAN.LibVLC.MediaList LibvlcMediaLibraryMediaList(global::VideoLAN.LibVLC.LibvlcMediaLibraryT p_mlib)
        {
            var __arg0 = ReferenceEquals(p_mlib, null) ? global::System.IntPtr.Zero : p_mlib.__Instance;
            var __ret = __Internal.LibvlcMediaLibraryMediaList(__arg0);
            global::VideoLAN.LibVLC.MediaList __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::VideoLAN.LibVLC.MediaList.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::VideoLAN.LibVLC.MediaList) global::VideoLAN.LibVLC.MediaList.NativeToManagedMap[__ret];
            else __result0 = global::VideoLAN.LibVLC.MediaList.__CreateInstance(__ret);
            return __result0;
        }
    }
}