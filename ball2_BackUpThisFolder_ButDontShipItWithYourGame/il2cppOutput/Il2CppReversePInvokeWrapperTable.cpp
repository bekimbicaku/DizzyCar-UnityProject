﻿#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <stdint.h>
#include <limits>



// System.Char[]
struct CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB;
// System.String
struct String_t;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;

struct unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902;
struct unitytls_key_ref_t6BD91D013DF11047C53738FEEB12CE290FDC71A2;
struct unitytls_tlsctx_tF8BBCBFE1E957B846442DED65ECB89BC5307DEAE;
struct unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17;
struct unitytls_x509name_t8A1108C917795D8FE946B50769ACE51489C7BF5D;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

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

// System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2  : public ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F
{
};

struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_StaticFields
{
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t799905CF001DD5F13F7DBB310181FC4D8B7D0AAB* ___enumSeperatorCharArray_0;
};
// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t2A1A94B24E3B776EEF4E5E485E290BB9D4D072E2_marshaled_com
{
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
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

// Mono.Unity.UnityTls/unitytls_x509_ref
struct unitytls_x509_ref_t9CEB17766B4144117333AB50379B21A357FA4333 
{
	// System.UInt64 Mono.Unity.UnityTls/unitytls_x509_ref::handle
	uint64_t ___handle_0;
};

// Mono.Unity.UnityTls/unitytls_x509list_ref
struct unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17 
{
	// System.UInt64 Mono.Unity.UnityTls/unitytls_x509list_ref::handle
	uint64_t ___handle_0;
};

// Mono.Unity.UnityTls/unitytls_x509verify_result
struct unitytls_x509verify_result_tBD0B93AE208F14C2C6CD925F0702A269BFE66FF0 
{
	// System.UInt32 Mono.Unity.UnityTls/unitytls_x509verify_result::value__
	uint32_t ___value___2;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif

extern "C" void DEFAULT_CALL ReversePInvokeWrapper_CultureInfo_OnCultureInfoChangedInAppX_mDBD419B094B2CFE933BB3F63886A5AB4E44D2DC0(Il2CppChar* ___language0);
extern "C" int32_t CDECL ReversePInvokeWrapper_DeflateStreamNative_UnmanagedRead_m79E9628F6FF91A3995491997242DD83046C9B704(intptr_t ___buffer0, int32_t ___length1, intptr_t ___data2);
extern "C" int32_t CDECL ReversePInvokeWrapper_DeflateStreamNative_UnmanagedWrite_m509AE153ECB916CDF755432335FBAB2B51CA1486(intptr_t ___buffer0, int32_t ___length1, intptr_t ___data2);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_OSSpecificSynchronizationContext_InvocationEntry_mB85BF0265E239960FC963DCA74DC67EBCE9480AC(intptr_t ___arg0);
extern "C" void CDECL ReversePInvokeWrapper_UnityTlsContext_CertificateCallback_mF5E626BA2545CFFA64428622678E409702C2045A(void* ___userData0, unitytls_tlsctx_tF8BBCBFE1E957B846442DED65ECB89BC5307DEAE* ___ctx1, uint8_t* ___cn2, intptr_t ___cnLen3, unitytls_x509name_t8A1108C917795D8FE946B50769ACE51489C7BF5D* ___caList4, intptr_t ___caListLen5, unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17* ___chain6, unitytls_key_ref_t6BD91D013DF11047C53738FEEB12CE290FDC71A2* ___key7, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState8);
extern "C" intptr_t CDECL ReversePInvokeWrapper_UnityTlsContext_ReadCallback_m15F3A217E44D480CAED06EB5A88503FB6259D7EC(void* ___userData0, uint8_t* ___buffer1, intptr_t ___bufferLen2, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState3);
extern "C" uint32_t CDECL ReversePInvokeWrapper_UnityTlsContext_VerifyCallback_m75D7C072718405EBBF8A2A9C794C4DDFB2595BD0(void* ___userData0, unitytls_x509list_ref_t6C5C1CF0B720516A681CB741104A164FD8B3CF17 ___chain1, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState2);
extern "C" intptr_t CDECL ReversePInvokeWrapper_UnityTlsContext_WriteCallback_m53DD70115C97432A676F3E437E8FB42F9FC068F5(void* ___userData0, uint8_t* ___data1, intptr_t ___bufferLen2, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState3);
extern "C" uint32_t CDECL ReversePInvokeWrapper_UnityTlsProvider_x509verify_callback_m47823254E133F7304ABFAE5A1F0D218402BC5B45(void* ___userData0, unitytls_x509_ref_t9CEB17766B4144117333AB50379B21A357FA4333 ___cert1, uint32_t ___result2, unitytls_errorstate_tC926EE4582920BE2C1DB1F3F65619B810D5AB902* ___errorState3);
extern "C" int32_t CDECL ReversePInvokeWrapper_BurstCompilerHelper_IsBurstEnabled_m5EFFD7E2094228A267B5DBC3F28B82A7FF53E733();


IL2CPP_EXTERN_C const Il2CppMethodPointer g_ReversePInvokeWrapperPointers[];
const Il2CppMethodPointer g_ReversePInvokeWrapperPointers[10] = 
{
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_CultureInfo_OnCultureInfoChangedInAppX_mDBD419B094B2CFE933BB3F63886A5AB4E44D2DC0),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_DeflateStreamNative_UnmanagedRead_m79E9628F6FF91A3995491997242DD83046C9B704),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_DeflateStreamNative_UnmanagedWrite_m509AE153ECB916CDF755432335FBAB2B51CA1486),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_OSSpecificSynchronizationContext_InvocationEntry_mB85BF0265E239960FC963DCA74DC67EBCE9480AC),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_CertificateCallback_mF5E626BA2545CFFA64428622678E409702C2045A),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_ReadCallback_m15F3A217E44D480CAED06EB5A88503FB6259D7EC),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_VerifyCallback_m75D7C072718405EBBF8A2A9C794C4DDFB2595BD0),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsContext_WriteCallback_m53DD70115C97432A676F3E437E8FB42F9FC068F5),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_UnityTlsProvider_x509verify_callback_m47823254E133F7304ABFAE5A1F0D218402BC5B45),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_BurstCompilerHelper_IsBurstEnabled_m5EFFD7E2094228A267B5DBC3F28B82A7FF53E733),
};
