using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UI_Host_API
{
    enum EXT_DLL_Result
    {
        EXT_DLL_Result_Error = -1,
        EXT_DLL_Result_OK = 0,
    };

    class API
    {
        const string PathToDebugDLL = @"..\..\BTBasic_CounterAPI_Debug\BTBasic_CounterAPI.dll";
        const string PathToReleaseDLL = @"..\..\BTBasic_CounterAPI_Release\BTBasic_CounterAPI.dll";

        #if DEBUG
            [DllImport(PathToDebugDLL, CallingConvention = CallingConvention.Cdecl, EntryPoint = "BTBasic_DLL_Call", CharSet = CharSet.Ansi)]
            unsafe public static extern EXT_DLL_Result BTBasic_DLL_Call(StringBuilder functionName, StringBuilder parameters, StringBuilder returnString, ref int returnValue);
        #else
            [DllImport(PathToReleaseDLL, CallingConvention = CallingConvention.Cdecl, EntryPoint = "BTBasic_DLL_Call", CharSet = CharSet.Ansi)]
            unsafe public static extern EXT_DLL_Result BTBasic_DLL_Call(StringBuilder functionName, StringBuilder parameters, StringBuilder returnString, ref int returnValue);
        #endif

        public string APICall(string functionName, string parameters)
        {
            StringBuilder functionNameStr = new StringBuilder(functionName);
            StringBuilder parametersStr = new StringBuilder(parameters);
            StringBuilder returnStringStr = new StringBuilder(new String(' ', 2047));
            int returnValue = 0;

            EXT_DLL_Result result = BTBasic_DLL_Call(functionNameStr, parametersStr, returnStringStr, ref returnValue);

            return returnStringStr.ToString();
        }
    }
}
