#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>


struct InterfaceActionInvoker0
{
	typedef void (*Action)(void*, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, invokeData.method);
	}
};

// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;
// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
// FMOD.Studio.COMMANDREPLAY_CREATE_INSTANCE_CALLBACK
struct COMMANDREPLAY_CREATE_INSTANCE_CALLBACK_t566A4FB8AC7199E902FBC56D7EE072847D58EA83;
// FMOD.Studio.COMMANDREPLAY_FRAME_CALLBACK
struct COMMANDREPLAY_FRAME_CALLBACK_t16B00605AE067BEFB859218A1F8ACC59949B70E5;
// FMOD.Studio.COMMANDREPLAY_LOAD_BANK_CALLBACK
struct COMMANDREPLAY_LOAD_BANK_CALLBACK_t4BD509917E57605E11DA3E96FE53C2E6A6D67B71;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// System.IAsyncResult
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// System.String
struct String_t;
// System.Text.UTF8Encoding
struct UTF8Encoding_t90B56215A1B0B7ED5CDEA772E695F0DDAFBCD3BE;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// FMOD.StringHelper/ThreadSafeEncoding
struct ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59;

IL2CPP_EXTERN_C RuntimeClass* IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* IntPtr_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* StringHelper_t1E0E1E18057E1AC7FD96DC167F9F849437ABC4C5_il2cpp_TypeInfo_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;

struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

// System.Byte
struct Byte_t94D9231AC217BE4D2E004C4CD32DF6D099EA41A3 
{
	// System.Byte System.Byte::m_value
	uint8_t ___m_value_0;
};

// FMOD.GUID
struct GUID_tFB268B4FFFA3CA85D227CAE412BC765F4B71BE54 
{
	// System.Int32 FMOD.GUID::Data1
	int32_t ___Data1_0;
	// System.Int32 FMOD.GUID::Data2
	int32_t ___Data2_1;
	// System.Int32 FMOD.GUID::Data3
	int32_t ___Data3_2;
	// System.Int32 FMOD.GUID::Data4
	int32_t ___Data4_3;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// FMOD.Studio.CommandReplay
struct CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181 
{
	// System.IntPtr FMOD.Studio.CommandReplay::handle
	intptr_t ___handle_0;
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// System.Runtime.InteropServices.GCHandle
struct GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC 
{
	// System.IntPtr System.Runtime.InteropServices.GCHandle::handle
	intptr_t ___handle_0;
};

// FMOD.StringWrapper
struct StringWrapper_t3224449C9F0E927E27B599C5F209AEF18C549B53 
{
	// System.IntPtr FMOD.StringWrapper::nativeUtf8Ptr
	intptr_t ___nativeUtf8Ptr_0;
};

// FMOD.Studio.System
struct System_t9A51FE13708186A22E9D4454A7EA18347C389FEC 
{
	// System.IntPtr FMOD.Studio.System::handle
	intptr_t ___handle_0;
};

// FMOD.Studio.COMMAND_INFO
struct COMMAND_INFO_tCBBD3E3B8F206BDA068D1F5E8DE83DC4327B0FDE 
{
	// FMOD.StringWrapper FMOD.Studio.COMMAND_INFO::commandname
	StringWrapper_t3224449C9F0E927E27B599C5F209AEF18C549B53 ___commandname_0;
	// System.Int32 FMOD.Studio.COMMAND_INFO::parentcommandindex
	int32_t ___parentcommandindex_1;
	// System.Int32 FMOD.Studio.COMMAND_INFO::framenumber
	int32_t ___framenumber_2;
	// System.Single FMOD.Studio.COMMAND_INFO::frametime
	float ___frametime_3;
	// FMOD.Studio.INSTANCETYPE FMOD.Studio.COMMAND_INFO::instancetype
	int32_t ___instancetype_4;
	// FMOD.Studio.INSTANCETYPE FMOD.Studio.COMMAND_INFO::outputtype
	int32_t ___outputtype_5;
	// System.UInt32 FMOD.Studio.COMMAND_INFO::instancehandle
	uint32_t ___instancehandle_6;
	// System.UInt32 FMOD.Studio.COMMAND_INFO::outputhandle
	uint32_t ___outputhandle_7;
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// FMOD.StringHelper/ThreadSafeEncoding
struct ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59  : public RuntimeObject
{
	// System.Text.UTF8Encoding FMOD.StringHelper/ThreadSafeEncoding::encoding
	UTF8Encoding_t90B56215A1B0B7ED5CDEA772E695F0DDAFBCD3BE* ___encoding_0;
	// System.Byte[] FMOD.StringHelper/ThreadSafeEncoding::encodedBuffer
	ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___encodedBuffer_1;
	// System.Char[] FMOD.StringHelper/ThreadSafeEncoding::decodedBuffer
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___decodedBuffer_2;
	// System.Boolean FMOD.StringHelper/ThreadSafeEncoding::inUse
	bool ___inUse_3;
	// System.Runtime.InteropServices.GCHandle FMOD.StringHelper/ThreadSafeEncoding::gcHandle
	GCHandle_tC44F6F72EE68BD4CFABA24309DA7A179D41127DC ___gcHandle_4;
};

// FMOD.Studio.COMMANDREPLAY_CREATE_INSTANCE_CALLBACK
struct COMMANDREPLAY_CREATE_INSTANCE_CALLBACK_t566A4FB8AC7199E902FBC56D7EE072847D58EA83  : public MulticastDelegate_t
{
};

// FMOD.Studio.COMMANDREPLAY_FRAME_CALLBACK
struct COMMANDREPLAY_FRAME_CALLBACK_t16B00605AE067BEFB859218A1F8ACC59949B70E5  : public MulticastDelegate_t
{
};

// FMOD.Studio.COMMANDREPLAY_LOAD_BANK_CALLBACK
struct COMMANDREPLAY_LOAD_BANK_CALLBACK_t4BD509917E57605E11DA3E96FE53C2E6A6D67B71  : public MulticastDelegate_t
{
};

// System.String
struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// System.String

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// System.Boolean

// System.Byte

// System.Byte

// System.Int32

// System.Int32

// System.IntPtr
struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// System.IntPtr

// System.Single

// System.Single

// System.Void

// System.Void

// FMOD.Studio.CommandReplay

// FMOD.Studio.CommandReplay

// FMOD.Studio.System

// FMOD.Studio.System

// FMOD.Studio.COMMAND_INFO

// FMOD.Studio.COMMAND_INFO

// FMOD.StringHelper/ThreadSafeEncoding

// FMOD.StringHelper/ThreadSafeEncoding

// FMOD.Studio.COMMANDREPLAY_CREATE_INSTANCE_CALLBACK

// FMOD.Studio.COMMANDREPLAY_CREATE_INSTANCE_CALLBACK

// FMOD.Studio.COMMANDREPLAY_FRAME_CALLBACK

// FMOD.Studio.COMMANDREPLAY_FRAME_CALLBACK

// FMOD.Studio.COMMANDREPLAY_LOAD_BANK_CALLBACK

// FMOD.Studio.COMMANDREPLAY_LOAD_BANK_CALLBACK
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Byte[]
struct ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031  : public RuntimeArray
{
	ALIGN_FIELD (8) uint8_t m_Items[1];

	inline uint8_t GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline uint8_t* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, uint8_t value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline uint8_t GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline uint8_t* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, uint8_t value)
	{
		m_Items[index] = value;
	}
};



// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetSystem(System.IntPtr,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetSystem_m3417DA8220C84C69EC70FE92C3F054A8D3D97867 (intptr_t ___0_replay, intptr_t* ___1_system, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::getSystem(FMOD.Studio.System&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getSystem_m3975D9948E6C613B0E61625BC3E900D8825FF221 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, System_t9A51FE13708186A22E9D4454A7EA18347C389FEC* ___0_system, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetLength(System.IntPtr,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetLength_m9E914345C0B5F66F180E9438621E12C93A1B5E04 (intptr_t ___0_replay, float* ___1_length, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::getLength(System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getLength_m59374A44E01D2601EE1E6F27F98F72EBC8701D41 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, float* ___0_length, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetCommandCount(System.IntPtr,System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetCommandCount_m75990CDF2D9630F06366FA00F71F75E057623D98 (intptr_t ___0_replay, int32_t* ___1_count, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::getCommandCount(System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getCommandCount_m8E072B60F1C567242C15A1862787CC35BD551C4B (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t* ___0_count, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetCommandInfo(System.IntPtr,System.Int32,FMOD.Studio.COMMAND_INFO&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetCommandInfo_m03FA862DCF1BAB3B0418CC1A87E5AC3948EE3CDA (intptr_t ___0_replay, int32_t ___1_commandindex, COMMAND_INFO_tCBBD3E3B8F206BDA068D1F5E8DE83DC4327B0FDE* ___2_info, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::getCommandInfo(System.Int32,FMOD.Studio.COMMAND_INFO&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getCommandInfo_m09C6E8A252FC23B44F1AA79CF2C68433BB019D8A (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t ___0_commandIndex, COMMAND_INFO_tCBBD3E3B8F206BDA068D1F5E8DE83DC4327B0FDE* ___1_info, const RuntimeMethod* method) ;
// FMOD.StringHelper/ThreadSafeEncoding FMOD.StringHelper::GetFreeHelper()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* StringHelper_GetFreeHelper_m2F250F570E165934A8E4BE9EA97C66A18997E1D2 (const RuntimeMethod* method) ;
// System.IntPtr System.Runtime.InteropServices.Marshal::AllocHGlobal(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR intptr_t Marshal_AllocHGlobal_mE1D700DF967E28BE8AB3E0D67C81A96B4FCC8F4F (int32_t ___0_cb, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetCommandString(System.IntPtr,System.Int32,System.IntPtr,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetCommandString_mA737A269290F03787EA8B676113B08F661F66F7C (intptr_t ___0_replay, int32_t ___1_commandIndex, intptr_t ___2_buffer, int32_t ___3_length, const RuntimeMethod* method) ;
// System.Void System.Runtime.InteropServices.Marshal::FreeHGlobal(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Marshal_FreeHGlobal_m298EF0650E82E326EDA8048488DC384BB9171EB9 (intptr_t ___0_hglobal, const RuntimeMethod* method) ;
// System.String FMOD.StringHelper/ThreadSafeEncoding::stringFromNative(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* ThreadSafeEncoding_stringFromNative_m1E3E0B3C49A45CD35E5821E5807855755EBD8979 (ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* __this, intptr_t ___0_nativePtr, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::getCommandString(System.Int32,System.String&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getCommandString_m305709FA9F239CC202C5EDCF0459F1100F887541 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t ___0_commandIndex, String_t** ___1_buffer, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetCommandAtTime(System.IntPtr,System.Single,System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetCommandAtTime_m27082E7D6E287A4B15C786D8564E7A0B37F53299 (intptr_t ___0_replay, float ___1_time, int32_t* ___2_commandIndex, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::getCommandAtTime(System.Single,System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getCommandAtTime_m32784099963DAFC104AD4609E46B1903F5975A83 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, float ___0_time, int32_t* ___1_commandIndex, const RuntimeMethod* method) ;
// System.Byte[] FMOD.StringHelper/ThreadSafeEncoding::byteFromStringUTF8(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ThreadSafeEncoding_byteFromStringUTF8_m47D29321D6BF684366C51EEA78A5F91A9A75E495 (ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* __this, String_t* ___0_s, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetBankPath(System.IntPtr,System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetBankPath_mC3A4273A3893723C982ED6075E740236ACC2964B (intptr_t ___0_replay, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___1_bankPath, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::setBankPath(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setBankPath_m526ADCBA5D8A9211B853FCBAE052AE16DDCBA7EA (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, String_t* ___0_bankPath, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_Start(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_Start_mE383B48766EFE6A6CBB27AFF0BCED473505A9644 (intptr_t ___0_replay, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_start_m01D627A157189259E060D729917E8F6343D249FF (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_Stop(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_Stop_m25A1A4F25F9F2766652DB763CB92CB51D19B5CBF (intptr_t ___0_replay, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::stop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_stop_mDE7CE2DD1DAFE237B347D00254FA8D7488DDC6E1 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SeekToTime(System.IntPtr,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SeekToTime_m73FF5FA117145B30B9C08F3F068FDE537C56A8BF (intptr_t ___0_replay, float ___1_time, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::seekToTime(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_seekToTime_m23B5C7DD6998E0F5E903C65714E13168554A1050 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, float ___0_time, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SeekToCommand(System.IntPtr,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SeekToCommand_m0E3D4FDDCD12271300965C0252251B168A14D814 (intptr_t ___0_replay, int32_t ___1_commandIndex, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::seekToCommand(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_seekToCommand_mD4A305EC8ED7BFEAC45ADB846AA0F996C043ED0C (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t ___0_commandIndex, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetPaused(System.IntPtr,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetPaused_mD4F6BB75F8D027B40115E80EBBC01EF1F488EF42 (intptr_t ___0_replay, bool* ___1_paused, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::getPaused(System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getPaused_m2E9545101D52CB7C9AC5633BFE7087C92222F015 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, bool* ___0_paused, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetPaused(System.IntPtr,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetPaused_m231DDD1819B80EC1922099F904965A4A104A47EB (intptr_t ___0_replay, bool ___1_paused, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::setPaused(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setPaused_m1FE0F75673CA69A673F07CB458A231803C2233C8 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, bool ___0_paused, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetPlaybackState(System.IntPtr,FMOD.Studio.PLAYBACK_STATE&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetPlaybackState_m5EFA36C232398C11F315051370365FC81CE14D3A (intptr_t ___0_replay, int32_t* ___1_state, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::getPlaybackState(FMOD.Studio.PLAYBACK_STATE&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getPlaybackState_m757DEC061DD1672922B8B234450A7E7C8AF8E2D2 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t* ___0_state, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetCurrentCommand(System.IntPtr,System.Int32&,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetCurrentCommand_m783495B11AD272FBDD629DBA76E6F022D7FBBBDD (intptr_t ___0_replay, int32_t* ___1_commandIndex, float* ___2_currentTime, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::getCurrentCommand(System.Int32&,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getCurrentCommand_mDDBB228F2E6DB13471E30137AAF9CC842450EEA4 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t* ___0_commandIndex, float* ___1_currentTime, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_Release(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_Release_m66C5DBA5B036F76E37C9C666D65A2D85C750CB42 (intptr_t ___0_replay, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::release()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_release_m43F0A5ECC3A689AAC23C8FB66FBCB9356DB12736 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetFrameCallback(System.IntPtr,FMOD.Studio.COMMANDREPLAY_FRAME_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetFrameCallback_mFBBA5792D8ED9971F2A4CB66E992B2E27B01894B (intptr_t ___0_replay, COMMANDREPLAY_FRAME_CALLBACK_t16B00605AE067BEFB859218A1F8ACC59949B70E5* ___1_callback, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::setFrameCallback(FMOD.Studio.COMMANDREPLAY_FRAME_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setFrameCallback_mD3EB81B79D214420EEE12C47813E314029B74A26 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, COMMANDREPLAY_FRAME_CALLBACK_t16B00605AE067BEFB859218A1F8ACC59949B70E5* ___0_callback, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetLoadBankCallback(System.IntPtr,FMOD.Studio.COMMANDREPLAY_LOAD_BANK_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetLoadBankCallback_mCA1489E0ED125B5D34D34FB4E74B4516607AC9C8 (intptr_t ___0_replay, COMMANDREPLAY_LOAD_BANK_CALLBACK_t4BD509917E57605E11DA3E96FE53C2E6A6D67B71* ___1_callback, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::setLoadBankCallback(FMOD.Studio.COMMANDREPLAY_LOAD_BANK_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setLoadBankCallback_m529AA6A3841B31F593CFB68BA6EB1AADAEFECCEF (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, COMMANDREPLAY_LOAD_BANK_CALLBACK_t4BD509917E57605E11DA3E96FE53C2E6A6D67B71* ___0_callback, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetCreateInstanceCallback(System.IntPtr,FMOD.Studio.COMMANDREPLAY_CREATE_INSTANCE_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetCreateInstanceCallback_m5FDA49EB67B9B4472F73E7C54999081808DB606B (intptr_t ___0_replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK_t566A4FB8AC7199E902FBC56D7EE072847D58EA83* ___1_callback, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::setCreateInstanceCallback(FMOD.Studio.COMMANDREPLAY_CREATE_INSTANCE_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setCreateInstanceCallback_mEA722F8DD50F627BD5A0A14B028CA5A05788A24F (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK_t566A4FB8AC7199E902FBC56D7EE072847D58EA83* ___0_callback, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetUserData(System.IntPtr,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetUserData_m273EBF32D9838C6029EB472DC6B99327347E6CFB (intptr_t ___0_replay, intptr_t* ___1_userdata, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::getUserData(System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getUserData_m246D0817CF3C2A454ABA0570F3A14FE8C3982424 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, intptr_t* ___0_userdata, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetUserData(System.IntPtr,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetUserData_m8A673E517AAC0933E0A11757B868B1861847ADE3 (intptr_t ___0_replay, intptr_t ___1_userdata, const RuntimeMethod* method) ;
// FMOD.RESULT FMOD.Studio.CommandReplay::setUserData(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setUserData_m3A093847BB757723002A2413377CCDD81296EF1D (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, intptr_t ___0_userdata, const RuntimeMethod* method) ;
// System.Void FMOD.Studio.CommandReplay::.ctor(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CommandReplay__ctor_m9E60808B13329D16E0D9B1452D49C1DC2391CD4B (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, intptr_t ___0_ptr, const RuntimeMethod* method) ;
// System.Boolean System.IntPtr::op_Inequality(System.IntPtr,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool IntPtr_op_Inequality_m90EFC9C4CAD9A33E309F2DDF98EE4E1DD253637B (intptr_t ___0_value1, intptr_t ___1_value2, const RuntimeMethod* method) ;
// System.Boolean FMOD.Studio.CommandReplay::hasHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool CommandReplay_hasHandle_m3FD356989282F16065AABD0EC59C90FC0C8C5CDA (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) ;
// System.Void FMOD.Studio.CommandReplay::clearHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CommandReplay_clearHandle_m49A7A2AB23364099409E073912E580C84D4DE619 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) ;
// System.Boolean FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_IsValid(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool CommandReplay_FMOD_Studio_CommandReplay_IsValid_mF3CFE9D41689E89700FD41C16605991B630651F6 (intptr_t ___0_replay, const RuntimeMethod* method) ;
// System.Boolean FMOD.Studio.CommandReplay::isValid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool CommandReplay_isValid_m3560824A986DB0935AB7D0FAF7E5A73F3AC7165F (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) ;
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_IsValid(intptr_t);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_GetSystem(intptr_t, intptr_t*);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_GetLength(intptr_t, float*);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_GetCommandCount(intptr_t, int32_t*);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_GetCommandInfo(intptr_t, int32_t, COMMAND_INFO_tCBBD3E3B8F206BDA068D1F5E8DE83DC4327B0FDE*);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_GetCommandString(intptr_t, int32_t, intptr_t, int32_t);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_GetCommandAtTime(intptr_t, float, int32_t*);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_SetBankPath(intptr_t, uint8_t*);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_Start(intptr_t);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_Stop(intptr_t);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_SeekToTime(intptr_t, float);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_SeekToCommand(intptr_t, int32_t);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_GetPaused(intptr_t, int32_t*);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_SetPaused(intptr_t, int32_t);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_GetPlaybackState(intptr_t, int32_t*);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_GetCurrentCommand(intptr_t, int32_t*, float*);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_Release(intptr_t);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_SetFrameCallback(intptr_t, Il2CppMethodPointer);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_SetLoadBankCallback(intptr_t, Il2CppMethodPointer);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_SetCreateInstanceCallback(intptr_t, Il2CppMethodPointer);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_GetUserData(intptr_t, intptr_t*);
#endif
#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
IL2CPP_EXTERN_C int32_t DEFAULT_CALL FMOD_Studio_CommandReplay_SetUserData(intptr_t, intptr_t);
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// FMOD.RESULT FMOD.Studio.CommandReplay::getSystem(FMOD.Studio.System&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getSystem_m3975D9948E6C613B0E61625BC3E900D8825FF221 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, System_t9A51FE13708186A22E9D4454A7EA18347C389FEC* ___0_system, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_GetSystem(this.handle, out system.handle);
		intptr_t L_0 = __this->___handle_0;
		System_t9A51FE13708186A22E9D4454A7EA18347C389FEC* L_1 = ___0_system;
		intptr_t* L_2 = (&L_1->___handle_0);
		int32_t L_3;
		L_3 = CommandReplay_FMOD_Studio_CommandReplay_GetSystem_m3417DA8220C84C69EC70FE92C3F054A8D3D97867(L_0, L_2, NULL);
		V_0 = L_3;
		goto IL_0015;
	}

IL_0015:
	{
		// }
		int32_t L_4 = V_0;
		return L_4;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_getSystem_m3975D9948E6C613B0E61625BC3E900D8825FF221_AdjustorThunk (RuntimeObject* __this, System_t9A51FE13708186A22E9D4454A7EA18347C389FEC* ___0_system, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_getSystem_m3975D9948E6C613B0E61625BC3E900D8825FF221(_thisAdjusted, ___0_system, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::getLength(System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getLength_m59374A44E01D2601EE1E6F27F98F72EBC8701D41 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, float* ___0_length, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_GetLength(this.handle, out length);
		intptr_t L_0 = __this->___handle_0;
		float* L_1 = ___0_length;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_GetLength_m9E914345C0B5F66F180E9438621E12C93A1B5E04(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_getLength_m59374A44E01D2601EE1E6F27F98F72EBC8701D41_AdjustorThunk (RuntimeObject* __this, float* ___0_length, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_getLength_m59374A44E01D2601EE1E6F27F98F72EBC8701D41(_thisAdjusted, ___0_length, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::getCommandCount(System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getCommandCount_m8E072B60F1C567242C15A1862787CC35BD551C4B (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t* ___0_count, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_GetCommandCount(this.handle, out count);
		intptr_t L_0 = __this->___handle_0;
		int32_t* L_1 = ___0_count;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_GetCommandCount_m75990CDF2D9630F06366FA00F71F75E057623D98(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_getCommandCount_m8E072B60F1C567242C15A1862787CC35BD551C4B_AdjustorThunk (RuntimeObject* __this, int32_t* ___0_count, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_getCommandCount_m8E072B60F1C567242C15A1862787CC35BD551C4B(_thisAdjusted, ___0_count, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::getCommandInfo(System.Int32,FMOD.Studio.COMMAND_INFO&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getCommandInfo_m09C6E8A252FC23B44F1AA79CF2C68433BB019D8A (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t ___0_commandIndex, COMMAND_INFO_tCBBD3E3B8F206BDA068D1F5E8DE83DC4327B0FDE* ___1_info, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_GetCommandInfo(this.handle, commandIndex, out info);
		intptr_t L_0 = __this->___handle_0;
		int32_t L_1 = ___0_commandIndex;
		COMMAND_INFO_tCBBD3E3B8F206BDA068D1F5E8DE83DC4327B0FDE* L_2 = ___1_info;
		int32_t L_3;
		L_3 = CommandReplay_FMOD_Studio_CommandReplay_GetCommandInfo_m03FA862DCF1BAB3B0418CC1A87E5AC3948EE3CDA(L_0, L_1, L_2, NULL);
		V_0 = L_3;
		goto IL_0011;
	}

IL_0011:
	{
		// }
		int32_t L_4 = V_0;
		return L_4;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_getCommandInfo_m09C6E8A252FC23B44F1AA79CF2C68433BB019D8A_AdjustorThunk (RuntimeObject* __this, int32_t ___0_commandIndex, COMMAND_INFO_tCBBD3E3B8F206BDA068D1F5E8DE83DC4327B0FDE* ___1_info, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_getCommandInfo_m09C6E8A252FC23B44F1AA79CF2C68433BB019D8A(_thisAdjusted, ___0_commandIndex, ___1_info, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::getCommandString(System.Int32,System.String&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getCommandString_m305709FA9F239CC202C5EDCF0459F1100F887541 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t ___0_commandIndex, String_t** ___1_buffer, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringHelper_t1E0E1E18057E1AC7FD96DC167F9F849437ABC4C5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* V_0 = NULL;
	int32_t V_1 = 0;
	intptr_t V_2;
	memset((&V_2), 0, sizeof(V_2));
	int32_t V_3 = 0;
	bool V_4 = false;
	bool V_5 = false;
	int32_t V_6 = 0;
	{
		// buffer = null;
		String_t** L_0 = ___1_buffer;
		*((RuntimeObject**)L_0) = (RuntimeObject*)NULL;
		Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_0, (void*)(RuntimeObject*)NULL);
		// using (StringHelper.ThreadSafeEncoding encoder = StringHelper.GetFreeHelper())
		il2cpp_codegen_runtime_class_init_inline(StringHelper_t1E0E1E18057E1AC7FD96DC167F9F849437ABC4C5_il2cpp_TypeInfo_var);
		ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* L_1;
		L_1 = StringHelper_GetFreeHelper_m2F250F570E165934A8E4BE9EA97C66A18997E1D2(NULL);
		V_0 = L_1;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_007c:
			{// begin finally (depth: 1)
				{
					ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* L_2 = V_0;
					if (!L_2)
					{
						goto IL_0086;
					}
				}
				{
					ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* L_3 = V_0;
					NullCheck(L_3);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_3);
				}

IL_0086:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			{
				// int stringLength = 256;
				V_1 = ((int32_t)256);
				// IntPtr stringMem = Marshal.AllocHGlobal(256);
				il2cpp_codegen_runtime_class_init_inline(Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var);
				intptr_t L_4;
				L_4 = Marshal_AllocHGlobal_mE1D700DF967E28BE8AB3E0D67C81A96B4FCC8F4F(((int32_t)256), NULL);
				V_2 = L_4;
				// RESULT result = FMOD_Studio_CommandReplay_GetCommandString(this.handle, commandIndex, stringMem, stringLength);
				intptr_t L_5 = __this->___handle_0;
				int32_t L_6 = ___0_commandIndex;
				intptr_t L_7 = V_2;
				int32_t L_8 = V_1;
				int32_t L_9;
				L_9 = CommandReplay_FMOD_Studio_CommandReplay_GetCommandString_mA737A269290F03787EA8B676113B08F661F66F7C(L_5, L_6, L_7, L_8, NULL);
				V_3 = L_9;
				goto IL_0050_1;
			}

IL_002d_1:
			{
				// Marshal.FreeHGlobal(stringMem);
				intptr_t L_10 = V_2;
				il2cpp_codegen_runtime_class_init_inline(Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var);
				Marshal_FreeHGlobal_m298EF0650E82E326EDA8048488DC384BB9171EB9(L_10, NULL);
				// stringLength *= 2;
				int32_t L_11 = V_1;
				V_1 = ((int32_t)il2cpp_codegen_multiply(L_11, 2));
				// stringMem = Marshal.AllocHGlobal(stringLength);
				int32_t L_12 = V_1;
				intptr_t L_13;
				L_13 = Marshal_AllocHGlobal_mE1D700DF967E28BE8AB3E0D67C81A96B4FCC8F4F(L_12, NULL);
				V_2 = L_13;
				// result = FMOD_Studio_CommandReplay_GetCommandString(this.handle, commandIndex, stringMem, stringLength);
				intptr_t L_14 = __this->___handle_0;
				int32_t L_15 = ___0_commandIndex;
				intptr_t L_16 = V_2;
				int32_t L_17 = V_1;
				int32_t L_18;
				L_18 = CommandReplay_FMOD_Studio_CommandReplay_GetCommandString_mA737A269290F03787EA8B676113B08F661F66F7C(L_14, L_15, L_16, L_17, NULL);
				V_3 = L_18;
			}

IL_0050_1:
			{
				// while (result == RESULT.ERR_TRUNCATED)
				int32_t L_19 = V_3;
				V_4 = (bool)((((int32_t)L_19) == ((int32_t)((int32_t)65)))? 1 : 0);
				bool L_20 = V_4;
				if (L_20)
				{
					goto IL_002d_1;
				}
			}
			{
				// if (result == RESULT.OK)
				int32_t L_21 = V_3;
				V_5 = (bool)((((int32_t)L_21) == ((int32_t)0))? 1 : 0);
				bool L_22 = V_5;
				if (!L_22)
				{
					goto IL_0070_1;
				}
			}
			{
				// buffer = encoder.stringFromNative(stringMem);
				String_t** L_23 = ___1_buffer;
				ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* L_24 = V_0;
				intptr_t L_25 = V_2;
				NullCheck(L_24);
				String_t* L_26;
				L_26 = ThreadSafeEncoding_stringFromNative_m1E3E0B3C49A45CD35E5821E5807855755EBD8979(L_24, L_25, NULL);
				*((RuntimeObject**)L_23) = (RuntimeObject*)L_26;
				Il2CppCodeGenWriteBarrier((void**)(RuntimeObject**)L_23, (void*)(RuntimeObject*)L_26);
			}

IL_0070_1:
			{
				// Marshal.FreeHGlobal(stringMem);
				intptr_t L_27 = V_2;
				il2cpp_codegen_runtime_class_init_inline(Marshal_tD976A56A90263C3CE2B780D4B1CADADE2E70B4A7_il2cpp_TypeInfo_var);
				Marshal_FreeHGlobal_m298EF0650E82E326EDA8048488DC384BB9171EB9(L_27, NULL);
				// return result;
				int32_t L_28 = V_3;
				V_6 = L_28;
				goto IL_0087;
			}
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0087:
	{
		// }
		int32_t L_29 = V_6;
		return L_29;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_getCommandString_m305709FA9F239CC202C5EDCF0459F1100F887541_AdjustorThunk (RuntimeObject* __this, int32_t ___0_commandIndex, String_t** ___1_buffer, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_getCommandString_m305709FA9F239CC202C5EDCF0459F1100F887541(_thisAdjusted, ___0_commandIndex, ___1_buffer, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::getCommandAtTime(System.Single,System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getCommandAtTime_m32784099963DAFC104AD4609E46B1903F5975A83 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, float ___0_time, int32_t* ___1_commandIndex, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_GetCommandAtTime(this.handle, time, out commandIndex);
		intptr_t L_0 = __this->___handle_0;
		float L_1 = ___0_time;
		int32_t* L_2 = ___1_commandIndex;
		int32_t L_3;
		L_3 = CommandReplay_FMOD_Studio_CommandReplay_GetCommandAtTime_m27082E7D6E287A4B15C786D8564E7A0B37F53299(L_0, L_1, L_2, NULL);
		V_0 = L_3;
		goto IL_0011;
	}

IL_0011:
	{
		// }
		int32_t L_4 = V_0;
		return L_4;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_getCommandAtTime_m32784099963DAFC104AD4609E46B1903F5975A83_AdjustorThunk (RuntimeObject* __this, float ___0_time, int32_t* ___1_commandIndex, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_getCommandAtTime_m32784099963DAFC104AD4609E46B1903F5975A83(_thisAdjusted, ___0_time, ___1_commandIndex, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::setBankPath(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setBankPath_m526ADCBA5D8A9211B853FCBAE052AE16DDCBA7EA (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, String_t* ___0_bankPath, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&StringHelper_t1E0E1E18057E1AC7FD96DC167F9F849437ABC4C5_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* V_0 = NULL;
	int32_t V_1 = 0;
	{
		// using (StringHelper.ThreadSafeEncoding encoder = StringHelper.GetFreeHelper())
		il2cpp_codegen_runtime_class_init_inline(StringHelper_t1E0E1E18057E1AC7FD96DC167F9F849437ABC4C5_il2cpp_TypeInfo_var);
		ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* L_0;
		L_0 = StringHelper_GetFreeHelper_m2F250F570E165934A8E4BE9EA97C66A18997E1D2(NULL);
		V_0 = L_0;
	}
	{
		auto __finallyBlock = il2cpp::utils::Finally([&]
		{

FINALLY_001d:
			{// begin finally (depth: 1)
				{
					ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* L_1 = V_0;
					if (!L_1)
					{
						goto IL_0027;
					}
				}
				{
					ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* L_2 = V_0;
					NullCheck(L_2);
					InterfaceActionInvoker0::Invoke(0 /* System.Void System.IDisposable::Dispose() */, IDisposable_t030E0496B4E0E4E4F086825007979AF51F7248C5_il2cpp_TypeInfo_var, L_2);
				}

IL_0027:
				{
					return;
				}
			}// end finally (depth: 1)
		});
		try
		{// begin try (depth: 1)
			// return FMOD_Studio_CommandReplay_SetBankPath(this.handle, encoder.byteFromStringUTF8(bankPath));
			intptr_t L_3 = __this->___handle_0;
			ThreadSafeEncoding_t5578529C7A9534C9BEAA158A7C94C774FDD1AF59* L_4 = V_0;
			String_t* L_5 = ___0_bankPath;
			NullCheck(L_4);
			ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* L_6;
			L_6 = ThreadSafeEncoding_byteFromStringUTF8_m47D29321D6BF684366C51EEA78A5F91A9A75E495(L_4, L_5, NULL);
			int32_t L_7;
			L_7 = CommandReplay_FMOD_Studio_CommandReplay_SetBankPath_mC3A4273A3893723C982ED6075E740236ACC2964B(L_3, L_6, NULL);
			V_1 = L_7;
			goto IL_0028;
		}// end try (depth: 1)
		catch(Il2CppExceptionWrapper& e)
		{
			__finallyBlock.StoreException(e.ex);
		}
	}

IL_0028:
	{
		// }
		int32_t L_8 = V_1;
		return L_8;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_setBankPath_m526ADCBA5D8A9211B853FCBAE052AE16DDCBA7EA_AdjustorThunk (RuntimeObject* __this, String_t* ___0_bankPath, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_setBankPath_m526ADCBA5D8A9211B853FCBAE052AE16DDCBA7EA(_thisAdjusted, ___0_bankPath, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_start_m01D627A157189259E060D729917E8F6343D249FF (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_Start(this.handle);
		intptr_t L_0 = __this->___handle_0;
		int32_t L_1;
		L_1 = CommandReplay_FMOD_Studio_CommandReplay_Start_mE383B48766EFE6A6CBB27AFF0BCED473505A9644(L_0, NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		// }
		int32_t L_2 = V_0;
		return L_2;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_start_m01D627A157189259E060D729917E8F6343D249FF_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_start_m01D627A157189259E060D729917E8F6343D249FF(_thisAdjusted, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::stop()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_stop_mDE7CE2DD1DAFE237B347D00254FA8D7488DDC6E1 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_Stop(this.handle);
		intptr_t L_0 = __this->___handle_0;
		int32_t L_1;
		L_1 = CommandReplay_FMOD_Studio_CommandReplay_Stop_m25A1A4F25F9F2766652DB763CB92CB51D19B5CBF(L_0, NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		// }
		int32_t L_2 = V_0;
		return L_2;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_stop_mDE7CE2DD1DAFE237B347D00254FA8D7488DDC6E1_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_stop_mDE7CE2DD1DAFE237B347D00254FA8D7488DDC6E1(_thisAdjusted, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::seekToTime(System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_seekToTime_m23B5C7DD6998E0F5E903C65714E13168554A1050 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, float ___0_time, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_SeekToTime(this.handle, time);
		intptr_t L_0 = __this->___handle_0;
		float L_1 = ___0_time;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_SeekToTime_m73FF5FA117145B30B9C08F3F068FDE537C56A8BF(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_seekToTime_m23B5C7DD6998E0F5E903C65714E13168554A1050_AdjustorThunk (RuntimeObject* __this, float ___0_time, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_seekToTime_m23B5C7DD6998E0F5E903C65714E13168554A1050(_thisAdjusted, ___0_time, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::seekToCommand(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_seekToCommand_mD4A305EC8ED7BFEAC45ADB846AA0F996C043ED0C (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t ___0_commandIndex, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_SeekToCommand(this.handle, commandIndex);
		intptr_t L_0 = __this->___handle_0;
		int32_t L_1 = ___0_commandIndex;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_SeekToCommand_m0E3D4FDDCD12271300965C0252251B168A14D814(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_seekToCommand_mD4A305EC8ED7BFEAC45ADB846AA0F996C043ED0C_AdjustorThunk (RuntimeObject* __this, int32_t ___0_commandIndex, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_seekToCommand_mD4A305EC8ED7BFEAC45ADB846AA0F996C043ED0C(_thisAdjusted, ___0_commandIndex, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::getPaused(System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getPaused_m2E9545101D52CB7C9AC5633BFE7087C92222F015 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, bool* ___0_paused, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_GetPaused(this.handle, out paused);
		intptr_t L_0 = __this->___handle_0;
		bool* L_1 = ___0_paused;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_GetPaused_mD4F6BB75F8D027B40115E80EBBC01EF1F488EF42(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_getPaused_m2E9545101D52CB7C9AC5633BFE7087C92222F015_AdjustorThunk (RuntimeObject* __this, bool* ___0_paused, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_getPaused_m2E9545101D52CB7C9AC5633BFE7087C92222F015(_thisAdjusted, ___0_paused, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::setPaused(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setPaused_m1FE0F75673CA69A673F07CB458A231803C2233C8 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, bool ___0_paused, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_SetPaused(this.handle, paused);
		intptr_t L_0 = __this->___handle_0;
		bool L_1 = ___0_paused;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_SetPaused_m231DDD1819B80EC1922099F904965A4A104A47EB(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_setPaused_m1FE0F75673CA69A673F07CB458A231803C2233C8_AdjustorThunk (RuntimeObject* __this, bool ___0_paused, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_setPaused_m1FE0F75673CA69A673F07CB458A231803C2233C8(_thisAdjusted, ___0_paused, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::getPlaybackState(FMOD.Studio.PLAYBACK_STATE&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getPlaybackState_m757DEC061DD1672922B8B234450A7E7C8AF8E2D2 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t* ___0_state, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_GetPlaybackState(this.handle, out state);
		intptr_t L_0 = __this->___handle_0;
		int32_t* L_1 = ___0_state;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_GetPlaybackState_m5EFA36C232398C11F315051370365FC81CE14D3A(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_getPlaybackState_m757DEC061DD1672922B8B234450A7E7C8AF8E2D2_AdjustorThunk (RuntimeObject* __this, int32_t* ___0_state, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_getPlaybackState_m757DEC061DD1672922B8B234450A7E7C8AF8E2D2(_thisAdjusted, ___0_state, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::getCurrentCommand(System.Int32&,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getCurrentCommand_mDDBB228F2E6DB13471E30137AAF9CC842450EEA4 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, int32_t* ___0_commandIndex, float* ___1_currentTime, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_GetCurrentCommand(this.handle, out commandIndex, out currentTime);
		intptr_t L_0 = __this->___handle_0;
		int32_t* L_1 = ___0_commandIndex;
		float* L_2 = ___1_currentTime;
		int32_t L_3;
		L_3 = CommandReplay_FMOD_Studio_CommandReplay_GetCurrentCommand_m783495B11AD272FBDD629DBA76E6F022D7FBBBDD(L_0, L_1, L_2, NULL);
		V_0 = L_3;
		goto IL_0011;
	}

IL_0011:
	{
		// }
		int32_t L_4 = V_0;
		return L_4;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_getCurrentCommand_mDDBB228F2E6DB13471E30137AAF9CC842450EEA4_AdjustorThunk (RuntimeObject* __this, int32_t* ___0_commandIndex, float* ___1_currentTime, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_getCurrentCommand_mDDBB228F2E6DB13471E30137AAF9CC842450EEA4(_thisAdjusted, ___0_commandIndex, ___1_currentTime, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::release()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_release_m43F0A5ECC3A689AAC23C8FB66FBCB9356DB12736 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_Release(this.handle);
		intptr_t L_0 = __this->___handle_0;
		int32_t L_1;
		L_1 = CommandReplay_FMOD_Studio_CommandReplay_Release_m66C5DBA5B036F76E37C9C666D65A2D85C750CB42(L_0, NULL);
		V_0 = L_1;
		goto IL_000f;
	}

IL_000f:
	{
		// }
		int32_t L_2 = V_0;
		return L_2;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_release_m43F0A5ECC3A689AAC23C8FB66FBCB9356DB12736_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_release_m43F0A5ECC3A689AAC23C8FB66FBCB9356DB12736(_thisAdjusted, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::setFrameCallback(FMOD.Studio.COMMANDREPLAY_FRAME_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setFrameCallback_mD3EB81B79D214420EEE12C47813E314029B74A26 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, COMMANDREPLAY_FRAME_CALLBACK_t16B00605AE067BEFB859218A1F8ACC59949B70E5* ___0_callback, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_SetFrameCallback(this.handle, callback);
		intptr_t L_0 = __this->___handle_0;
		COMMANDREPLAY_FRAME_CALLBACK_t16B00605AE067BEFB859218A1F8ACC59949B70E5* L_1 = ___0_callback;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_SetFrameCallback_mFBBA5792D8ED9971F2A4CB66E992B2E27B01894B(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_setFrameCallback_mD3EB81B79D214420EEE12C47813E314029B74A26_AdjustorThunk (RuntimeObject* __this, COMMANDREPLAY_FRAME_CALLBACK_t16B00605AE067BEFB859218A1F8ACC59949B70E5* ___0_callback, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_setFrameCallback_mD3EB81B79D214420EEE12C47813E314029B74A26(_thisAdjusted, ___0_callback, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::setLoadBankCallback(FMOD.Studio.COMMANDREPLAY_LOAD_BANK_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setLoadBankCallback_m529AA6A3841B31F593CFB68BA6EB1AADAEFECCEF (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, COMMANDREPLAY_LOAD_BANK_CALLBACK_t4BD509917E57605E11DA3E96FE53C2E6A6D67B71* ___0_callback, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_SetLoadBankCallback(this.handle, callback);
		intptr_t L_0 = __this->___handle_0;
		COMMANDREPLAY_LOAD_BANK_CALLBACK_t4BD509917E57605E11DA3E96FE53C2E6A6D67B71* L_1 = ___0_callback;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_SetLoadBankCallback_mCA1489E0ED125B5D34D34FB4E74B4516607AC9C8(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_setLoadBankCallback_m529AA6A3841B31F593CFB68BA6EB1AADAEFECCEF_AdjustorThunk (RuntimeObject* __this, COMMANDREPLAY_LOAD_BANK_CALLBACK_t4BD509917E57605E11DA3E96FE53C2E6A6D67B71* ___0_callback, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_setLoadBankCallback_m529AA6A3841B31F593CFB68BA6EB1AADAEFECCEF(_thisAdjusted, ___0_callback, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::setCreateInstanceCallback(FMOD.Studio.COMMANDREPLAY_CREATE_INSTANCE_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setCreateInstanceCallback_mEA722F8DD50F627BD5A0A14B028CA5A05788A24F (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK_t566A4FB8AC7199E902FBC56D7EE072847D58EA83* ___0_callback, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_SetCreateInstanceCallback(this.handle, callback);
		intptr_t L_0 = __this->___handle_0;
		COMMANDREPLAY_CREATE_INSTANCE_CALLBACK_t566A4FB8AC7199E902FBC56D7EE072847D58EA83* L_1 = ___0_callback;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_SetCreateInstanceCallback_m5FDA49EB67B9B4472F73E7C54999081808DB606B(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_setCreateInstanceCallback_mEA722F8DD50F627BD5A0A14B028CA5A05788A24F_AdjustorThunk (RuntimeObject* __this, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK_t566A4FB8AC7199E902FBC56D7EE072847D58EA83* ___0_callback, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_setCreateInstanceCallback_mEA722F8DD50F627BD5A0A14B028CA5A05788A24F(_thisAdjusted, ___0_callback, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::getUserData(System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_getUserData_m246D0817CF3C2A454ABA0570F3A14FE8C3982424 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, intptr_t* ___0_userdata, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_GetUserData(this.handle, out userdata);
		intptr_t L_0 = __this->___handle_0;
		intptr_t* L_1 = ___0_userdata;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_GetUserData_m273EBF32D9838C6029EB472DC6B99327347E6CFB(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_getUserData_m246D0817CF3C2A454ABA0570F3A14FE8C3982424_AdjustorThunk (RuntimeObject* __this, intptr_t* ___0_userdata, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_getUserData_m246D0817CF3C2A454ABA0570F3A14FE8C3982424(_thisAdjusted, ___0_userdata, method);
	return _returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::setUserData(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_setUserData_m3A093847BB757723002A2413377CCDD81296EF1D (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, intptr_t ___0_userdata, const RuntimeMethod* method) 
{
	int32_t V_0 = 0;
	{
		// return FMOD_Studio_CommandReplay_SetUserData(this.handle, userdata);
		intptr_t L_0 = __this->___handle_0;
		intptr_t L_1 = ___0_userdata;
		int32_t L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_SetUserData_m8A673E517AAC0933E0A11757B868B1861847ADE3(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0010;
	}

IL_0010:
	{
		// }
		int32_t L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  int32_t CommandReplay_setUserData_m3A093847BB757723002A2413377CCDD81296EF1D_AdjustorThunk (RuntimeObject* __this, intptr_t ___0_userdata, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	int32_t _returnValue;
	_returnValue = CommandReplay_setUserData_m3A093847BB757723002A2413377CCDD81296EF1D(_thisAdjusted, ___0_userdata, method);
	return _returnValue;
}
// System.Boolean FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_IsValid(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool CommandReplay_FMOD_Studio_CommandReplay_IsValid_mF3CFE9D41689E89700FD41C16605991B630651F6 (intptr_t ___0_replay, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_IsValid", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_IsValid)(___0_replay);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay);
	#endif

	return static_cast<bool>(returnValue);
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetSystem(System.IntPtr,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetSystem_m3417DA8220C84C69EC70FE92C3F054A8D3D97867 (intptr_t ___0_replay, intptr_t* ___1_system, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, intptr_t*);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(intptr_t*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_GetSystem", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_GetSystem)(___0_replay, ___1_system);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_system);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetLength(System.IntPtr,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetLength_m9E914345C0B5F66F180E9438621E12C93A1B5E04 (intptr_t ___0_replay, float* ___1_length, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, float*);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(float*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_GetLength", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_GetLength)(___0_replay, ___1_length);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_length);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetCommandCount(System.IntPtr,System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetCommandCount_m75990CDF2D9630F06366FA00F71F75E057623D98 (intptr_t ___0_replay, int32_t* ___1_count, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, int32_t*);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(int32_t*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_GetCommandCount", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_GetCommandCount)(___0_replay, ___1_count);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_count);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetCommandInfo(System.IntPtr,System.Int32,FMOD.Studio.COMMAND_INFO&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetCommandInfo_m03FA862DCF1BAB3B0418CC1A87E5AC3948EE3CDA (intptr_t ___0_replay, int32_t ___1_commandindex, COMMAND_INFO_tCBBD3E3B8F206BDA068D1F5E8DE83DC4327B0FDE* ___2_info, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, int32_t, COMMAND_INFO_tCBBD3E3B8F206BDA068D1F5E8DE83DC4327B0FDE*);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(int32_t) + sizeof(COMMAND_INFO_tCBBD3E3B8F206BDA068D1F5E8DE83DC4327B0FDE*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_GetCommandInfo", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_GetCommandInfo)(___0_replay, ___1_commandindex, ___2_info);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_commandindex, ___2_info);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetCommandString(System.IntPtr,System.Int32,System.IntPtr,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetCommandString_mA737A269290F03787EA8B676113B08F661F66F7C (intptr_t ___0_replay, int32_t ___1_commandIndex, intptr_t ___2_buffer, int32_t ___3_length, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, int32_t, intptr_t, int32_t);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(int32_t) + sizeof(intptr_t) + sizeof(int32_t);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_GetCommandString", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_GetCommandString)(___0_replay, ___1_commandIndex, ___2_buffer, ___3_length);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_commandIndex, ___2_buffer, ___3_length);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetCommandAtTime(System.IntPtr,System.Single,System.Int32&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetCommandAtTime_m27082E7D6E287A4B15C786D8564E7A0B37F53299 (intptr_t ___0_replay, float ___1_time, int32_t* ___2_commandIndex, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, float, int32_t*);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(float) + sizeof(int32_t*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_GetCommandAtTime", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_GetCommandAtTime)(___0_replay, ___1_time, ___2_commandIndex);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_time, ___2_commandIndex);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetBankPath(System.IntPtr,System.Byte[])
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetBankPath_mC3A4273A3893723C982ED6075E740236ACC2964B (intptr_t ___0_replay, ByteU5BU5D_tA6237BF417AE52AD70CFB4EF24A7A82613DF9031* ___1_bankPath, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, uint8_t*);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(void*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_SetBankPath", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Marshaling of parameter '___1_bankPath' to native representation
	uint8_t* ____1_bankPath_marshaled = NULL;
	if (___1_bankPath != NULL)
	{
		____1_bankPath_marshaled = reinterpret_cast<uint8_t*>((___1_bankPath)->GetAddressAtUnchecked(0));
	}

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_SetBankPath)(___0_replay, ____1_bankPath_marshaled);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ____1_bankPath_marshaled);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_Start(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_Start_mE383B48766EFE6A6CBB27AFF0BCED473505A9644 (intptr_t ___0_replay, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_Start", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_Start)(___0_replay);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_Stop(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_Stop_m25A1A4F25F9F2766652DB763CB92CB51D19B5CBF (intptr_t ___0_replay, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_Stop", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_Stop)(___0_replay);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SeekToTime(System.IntPtr,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SeekToTime_m73FF5FA117145B30B9C08F3F068FDE537C56A8BF (intptr_t ___0_replay, float ___1_time, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, float);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(float);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_SeekToTime", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_SeekToTime)(___0_replay, ___1_time);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_time);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SeekToCommand(System.IntPtr,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SeekToCommand_m0E3D4FDDCD12271300965C0252251B168A14D814 (intptr_t ___0_replay, int32_t ___1_commandIndex, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, int32_t);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(int32_t);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_SeekToCommand", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_SeekToCommand)(___0_replay, ___1_commandIndex);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_commandIndex);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetPaused(System.IntPtr,System.Boolean&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetPaused_mD4F6BB75F8D027B40115E80EBBC01EF1F488EF42 (intptr_t ___0_replay, bool* ___1_paused, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, int32_t*);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(int32_t*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_GetPaused", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Marshaling of parameter '___1_paused' to native representation
	int32_t ____1_paused_empty = 0;
	int32_t* ____1_paused_marshaled = &____1_paused_empty;

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_GetPaused)(___0_replay, ____1_paused_marshaled);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ____1_paused_marshaled);
	#endif

	// Marshaling of parameter '___1_paused' back from native representation
	bool _____1_paused_marshaled_unmarshaled_dereferenced = false;
	_____1_paused_marshaled_unmarshaled_dereferenced = static_cast<bool>(*____1_paused_marshaled);
	*___1_paused = _____1_paused_marshaled_unmarshaled_dereferenced;

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetPaused(System.IntPtr,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetPaused_m231DDD1819B80EC1922099F904965A4A104A47EB (intptr_t ___0_replay, bool ___1_paused, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, int32_t);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + 4;
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_SetPaused", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_SetPaused)(___0_replay, static_cast<int32_t>(___1_paused));
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, static_cast<int32_t>(___1_paused));
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetPlaybackState(System.IntPtr,FMOD.Studio.PLAYBACK_STATE&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetPlaybackState_m5EFA36C232398C11F315051370365FC81CE14D3A (intptr_t ___0_replay, int32_t* ___1_state, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, int32_t*);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(int32_t*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_GetPlaybackState", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_GetPlaybackState)(___0_replay, ___1_state);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_state);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetCurrentCommand(System.IntPtr,System.Int32&,System.Single&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetCurrentCommand_m783495B11AD272FBDD629DBA76E6F022D7FBBBDD (intptr_t ___0_replay, int32_t* ___1_commandIndex, float* ___2_currentTime, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, int32_t*, float*);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(int32_t*) + sizeof(float*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_GetCurrentCommand", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_GetCurrentCommand)(___0_replay, ___1_commandIndex, ___2_currentTime);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_commandIndex, ___2_currentTime);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_Release(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_Release_m66C5DBA5B036F76E37C9C666D65A2D85C750CB42 (intptr_t ___0_replay, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_Release", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_Release)(___0_replay);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetFrameCallback(System.IntPtr,FMOD.Studio.COMMANDREPLAY_FRAME_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetFrameCallback_mFBBA5792D8ED9971F2A4CB66E992B2E27B01894B (intptr_t ___0_replay, COMMANDREPLAY_FRAME_CALLBACK_t16B00605AE067BEFB859218A1F8ACC59949B70E5* ___1_callback, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, Il2CppMethodPointer);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(void*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_SetFrameCallback", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Marshaling of parameter '___1_callback' to native representation
	Il2CppMethodPointer ____1_callback_marshaled = NULL;
	____1_callback_marshaled = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(___1_callback));

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_SetFrameCallback)(___0_replay, ____1_callback_marshaled);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ____1_callback_marshaled);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetLoadBankCallback(System.IntPtr,FMOD.Studio.COMMANDREPLAY_LOAD_BANK_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetLoadBankCallback_mCA1489E0ED125B5D34D34FB4E74B4516607AC9C8 (intptr_t ___0_replay, COMMANDREPLAY_LOAD_BANK_CALLBACK_t4BD509917E57605E11DA3E96FE53C2E6A6D67B71* ___1_callback, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, Il2CppMethodPointer);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(void*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_SetLoadBankCallback", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Marshaling of parameter '___1_callback' to native representation
	Il2CppMethodPointer ____1_callback_marshaled = NULL;
	____1_callback_marshaled = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(___1_callback));

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_SetLoadBankCallback)(___0_replay, ____1_callback_marshaled);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ____1_callback_marshaled);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetCreateInstanceCallback(System.IntPtr,FMOD.Studio.COMMANDREPLAY_CREATE_INSTANCE_CALLBACK)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetCreateInstanceCallback_m5FDA49EB67B9B4472F73E7C54999081808DB606B (intptr_t ___0_replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK_t566A4FB8AC7199E902FBC56D7EE072847D58EA83* ___1_callback, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, Il2CppMethodPointer);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(void*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_SetCreateInstanceCallback", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Marshaling of parameter '___1_callback' to native representation
	Il2CppMethodPointer ____1_callback_marshaled = NULL;
	____1_callback_marshaled = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(___1_callback));

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_SetCreateInstanceCallback)(___0_replay, ____1_callback_marshaled);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ____1_callback_marshaled);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_GetUserData(System.IntPtr,System.IntPtr&)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_GetUserData_m273EBF32D9838C6029EB472DC6B99327347E6CFB (intptr_t ___0_replay, intptr_t* ___1_userdata, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, intptr_t*);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(intptr_t*);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_GetUserData", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_GetUserData)(___0_replay, ___1_userdata);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_userdata);
	#endif

	return returnValue;
}
// FMOD.RESULT FMOD.Studio.CommandReplay::FMOD_Studio_CommandReplay_SetUserData(System.IntPtr,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t CommandReplay_FMOD_Studio_CommandReplay_SetUserData_m8A673E517AAC0933E0A11757B868B1861847ADE3 (intptr_t ___0_replay, intptr_t ___1_userdata, const RuntimeMethod* method) 
{
	typedef int32_t (DEFAULT_CALL *PInvokeFunc) (intptr_t, intptr_t);
	#if !FORCE_PINVOKE_INTERNAL && !FORCE_PINVOKE_fmodstudioL_INTERNAL
	static PInvokeFunc il2cppPInvokeFunc;
	if (il2cppPInvokeFunc == NULL)
	{
		int parameterSize = sizeof(intptr_t) + sizeof(intptr_t);
		il2cppPInvokeFunc = il2cpp_codegen_resolve_pinvoke<PInvokeFunc>(IL2CPP_NATIVE_STRING("fmodstudioL"), "FMOD_Studio_CommandReplay_SetUserData", IL2CPP_CALL_DEFAULT, CHARSET_NOT_SPECIFIED, parameterSize, false);
		IL2CPP_ASSERT(il2cppPInvokeFunc != NULL);
	}
	#endif

	// Native function invocation
	#if FORCE_PINVOKE_INTERNAL || FORCE_PINVOKE_fmodstudioL_INTERNAL
	int32_t returnValue = reinterpret_cast<PInvokeFunc>(FMOD_Studio_CommandReplay_SetUserData)(___0_replay, ___1_userdata);
	#else
	int32_t returnValue = il2cppPInvokeFunc(___0_replay, ___1_userdata);
	#endif

	return returnValue;
}
// System.Void FMOD.Studio.CommandReplay::.ctor(System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CommandReplay__ctor_m9E60808B13329D16E0D9B1452D49C1DC2391CD4B (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, intptr_t ___0_ptr, const RuntimeMethod* method) 
{
	{
		// public CommandReplay(IntPtr ptr) { this.handle = ptr; }
		intptr_t L_0 = ___0_ptr;
		__this->___handle_0 = L_0;
		// public CommandReplay(IntPtr ptr) { this.handle = ptr; }
		return;
	}
}
IL2CPP_EXTERN_C  void CommandReplay__ctor_m9E60808B13329D16E0D9B1452D49C1DC2391CD4B_AdjustorThunk (RuntimeObject* __this, intptr_t ___0_ptr, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	CommandReplay__ctor_m9E60808B13329D16E0D9B1452D49C1DC2391CD4B(_thisAdjusted, ___0_ptr, method);
}
// System.Boolean FMOD.Studio.CommandReplay::hasHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool CommandReplay_hasHandle_m3FD356989282F16065AABD0EC59C90FC0C8C5CDA (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		// public bool hasHandle()          { return this.handle != IntPtr.Zero; }
		intptr_t L_0 = __this->___handle_0;
		intptr_t L_1 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		bool L_2;
		L_2 = IntPtr_op_Inequality_m90EFC9C4CAD9A33E309F2DDF98EE4E1DD253637B(L_0, L_1, NULL);
		V_0 = L_2;
		goto IL_0014;
	}

IL_0014:
	{
		// public bool hasHandle()          { return this.handle != IntPtr.Zero; }
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool CommandReplay_hasHandle_m3FD356989282F16065AABD0EC59C90FC0C8C5CDA_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	bool _returnValue;
	_returnValue = CommandReplay_hasHandle_m3FD356989282F16065AABD0EC59C90FC0C8C5CDA(_thisAdjusted, method);
	return _returnValue;
}
// System.Void FMOD.Studio.CommandReplay::clearHandle()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CommandReplay_clearHandle_m49A7A2AB23364099409E073912E580C84D4DE619 (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&IntPtr_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public void clearHandle()        { this.handle = IntPtr.Zero; }
		intptr_t L_0 = ((IntPtr_t_StaticFields*)il2cpp_codegen_static_fields_for(IntPtr_t_il2cpp_TypeInfo_var))->___Zero_1;
		__this->___handle_0 = L_0;
		// public void clearHandle()        { this.handle = IntPtr.Zero; }
		return;
	}
}
IL2CPP_EXTERN_C  void CommandReplay_clearHandle_m49A7A2AB23364099409E073912E580C84D4DE619_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	CommandReplay_clearHandle_m49A7A2AB23364099409E073912E580C84D4DE619(_thisAdjusted, method);
}
// System.Boolean FMOD.Studio.CommandReplay::isValid()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool CommandReplay_isValid_m3560824A986DB0935AB7D0FAF7E5A73F3AC7165F (CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* __this, const RuntimeMethod* method) 
{
	bool V_0 = false;
	int32_t G_B3_0 = 0;
	{
		// return hasHandle() && FMOD_Studio_CommandReplay_IsValid(this.handle);
		bool L_0;
		L_0 = CommandReplay_hasHandle_m3FD356989282F16065AABD0EC59C90FC0C8C5CDA(__this, NULL);
		if (!L_0)
		{
			goto IL_0016;
		}
	}
	{
		intptr_t L_1 = __this->___handle_0;
		bool L_2;
		L_2 = CommandReplay_FMOD_Studio_CommandReplay_IsValid_mF3CFE9D41689E89700FD41C16605991B630651F6(L_1, NULL);
		G_B3_0 = ((int32_t)(L_2));
		goto IL_0017;
	}

IL_0016:
	{
		G_B3_0 = 0;
	}

IL_0017:
	{
		V_0 = (bool)G_B3_0;
		goto IL_001a;
	}

IL_001a:
	{
		// }
		bool L_3 = V_0;
		return L_3;
	}
}
IL2CPP_EXTERN_C  bool CommandReplay_isValid_m3560824A986DB0935AB7D0FAF7E5A73F3AC7165F_AdjustorThunk (RuntimeObject* __this, const RuntimeMethod* method)
{
	CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181* _thisAdjusted;
	int32_t _offset = 1;
	_thisAdjusted = reinterpret_cast<CommandReplay_t25DD3D9655461AB14C7B88E6ADDD285DEF395181*>(__this + _offset);
	bool _returnValue;
	_returnValue = CommandReplay_isValid_m3560824A986DB0935AB7D0FAF7E5A73F3AC7165F(_thisAdjusted, method);
	return _returnValue;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
