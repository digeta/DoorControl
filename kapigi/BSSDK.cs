using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace kapigi
{
    class BSSDK
    {
        //
        // API Declarations
        //
        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            CallingConvention = CallingConvention.Winapi,
            EntryPoint = "BS_InitSDK")]
        public static extern int BS_InitSDK();

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_OpenInternalUDP")]
        public static extern int BS_OpenInternalUDP( ref int handle );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_SearchDeviceInLAN")]
        public static extern int BS_SearchDeviceInLAN(int handle, ref int numOfDevice, uint[] deviceIDs, int[] deviceTypes, uint[] readerAddrs );

        [DllImport("BS_SDK.dll",
              CharSet = CharSet.Ansi,
              EntryPoint = "BS_RelayControlEx")]
        public static extern int BS_RelayControlEx(int handle, int deviceIndex, int relayIndex, bool onoff);


        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetDeviceID")]
        public static extern int BS_GetDeviceID(int handle, ref uint deviceID, ref int deviceType);


        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_DoorControl")]
        public static extern int BS_DoorControl(int handle, int doorIndex, bool onoff);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_SetDeviceID")]
        public static extern int BS_SetDeviceID(int handle, uint deviceID, int deviceType );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadConfig")]
        public static extern int BS_ReadConfig(int handle, int configType, ref int configSize, IntPtr data);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_WriteConfig")]
        public static extern int BS_WriteConfig(int handle, int configType, int configSize, IntPtr data);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadConfigUDP")]
        public static extern int BS_ReadConfigUDP(int handle, uint targetAddr, uint targetID, int configType, ref int configSize, IntPtr data);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_WriteConfigUDP")]
        public static extern int BS_WriteConfigUDP(int handle, uint targetAddr, uint targetID, int configType, int configSize, IntPtr data);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_OpenSocket")]
        public static extern int BS_OpenSocket(string addr, int port, ref int handle);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_OpenSocketEx")]
        public static extern int BS_OpenSocket(string addr, int port, string hostaddr, ref int handle);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_CloseSocket")]
        public static extern int BS_CloseSocket(int handle);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_Disable")]
        public static extern int BS_Disable(int handle, int nTimeout);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_Enable")]
        public static extern int BS_Enable(int handle);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetTime")]
        public static extern int BS_GetTime(int handle, ref int timeVal);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_SetTime")]
        public static extern int BS_SetTime(int handle, int timeVal);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserDBInfo")]
        public static extern int BS_GetUserDBInfo(int handle, ref int numOfUser, ref int numOfTemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserFaceInfo")]
        public static extern int BS_GetUserFaceInfo(int handle, ref int numOfUser, ref int numOfTemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetAllUserInfoBEPlus")]
        public static extern int BS_GetAllUserInfoBEPlus(int handle, IntPtr userHdr, ref int numOfUser);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetAllUserInfoEx")]
        public static extern int BS_GetAllUserInfoEx(int handle, IntPtr userHdr, ref int numOfUser);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetAllUserInfoDStation")]
        public static extern int BS_GetAllUserInfoDStation(int handle, IntPtr userHdr, ref int numOfUser);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetAllUserInfoXStation")]
        public static extern int BS_GetAllUserInfoXStation(int handle, IntPtr userHdr, ref int numOfUser);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetAllUserInfoBioStation2")]
        public static extern int BS_GetAllUserInfoBioStation2(int handle, IntPtr userHdr, ref int numOfUser);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetAllUserInfoFStation")]
        public static extern int BS_GetAllUserInfoFStation(int handle, IntPtr userHdr, ref int numOfUser);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetAllUserInfoFStationEx")]
        public static extern int BS_GetAllUserInfoFStationEx(int handle, IntPtr userHdr, ref int numOfUser);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserInfoBEPlus")]
        public static extern int BS_GetUserInfoBEPlus(int handle, uint userID, IntPtr userHdr );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserInfoDStation")]
        public static extern int BS_GetUserInfoDStation(int handle, uint userID, IntPtr userHdr);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserInfoXStation")]
        public static extern int BS_GetUserInfoXStation(int handle, uint userID, IntPtr userHdr);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserInfoBioStation2")]
        public static extern int BS_GetUserInfoBioStation2(int handle, uint userID, IntPtr userHdr);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserInfoFStation")]
        public static extern int BS_GetUserInfoFStation(int handle, uint userID, IntPtr userHdr);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserInfoFStationEx")]
        public static extern int BS_GetUserInfoFStationEx(int handle, uint userID, IntPtr userHdr);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_DeleteUser")]
        public static extern int BS_DeleteUser(int handle, uint userID);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_DeleteAllUser")]
        public static extern int BS_DeleteAllUser(int handle);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserBEPlus")]
        public static extern int BS_GetUserBEPlus(int handle, uint userID, IntPtr userHdr, byte[] templateData);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserEx")]
        public static extern int BS_GetUserEx(int handle, uint userID, IntPtr userHdr, byte[] templateData);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserDStation")]
        public static extern int BS_GetUserDStation(int handle, uint userID, IntPtr userHdr, byte[] templateData, byte[] facetemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserXStation")]
        public static extern int BS_GetUserXStation(int handle, uint userID, IntPtr userHdr);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserBioStation2")]
        public static extern int BS_GetUserBioStation2(int handle, uint userID, IntPtr userHdr, byte[] templateData);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserFStation")]
        public static extern int BS_GetUserFStation(int handle, uint userID, IntPtr userHdr, byte[] faceTemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetUserFStationEx")]
        public static extern int BS_GetUserFStationEx(int handle, uint userID, IntPtr userHdr, byte[] imageData, byte[] faceTemplate);
        
        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollUserBEPlus")]
        public static extern int BS_EnrollUserBEPlus(int handle, IntPtr userHdr, byte[] templateData);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollMultipleUserBEPlus")]
        public static extern int BS_EnrollMultipleUserBEPlus(int handle, int numofUser, IntPtr userHdr, byte[] templateData);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollUserEx")]
        public static extern int BS_EnrollUserEx(int handle, IntPtr userHdr, byte[] templateData);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollMultipleUserEx")]
        public static extern int BS_EnrollMultipleUserEx(int handle, int numOfUser, IntPtr userHdr, byte[] templateData);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollUserDStation")]
        public static extern int BS_EnrollUserDStation(int handle, IntPtr userHdr, byte[] fingerTemplate, byte[] faceTemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollMultipleUserDStation")]
        public static extern int BS_EnrollMultipleUserDStation(int handle, int numOfUser, IntPtr userHdr, byte[] fingerTemplate, byte[] faceTemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollUserXStation")]
        public static extern int BS_EnrollUserXStation(int handle, IntPtr userHdr);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollMultipleUserXStation")]
        public static extern int BS_EnrollMultipleUserXStation(int handle, int numOfUser, IntPtr userHdr);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollUserBioStation2")]
        public static extern int BS_EnrollUserBioStation2(int handle, IntPtr userHdr, byte[] templateData);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollMultipleUserBioStation2")]
        public static extern int BS_EnrollMultipleUserBioStation2(int handle, int numOfUser, IntPtr userHdr, byte[] templateData);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollUserFStation")]
        public static extern int BS_EnrollUserFStation(int handle, IntPtr userHdr, byte[] faceTemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollUserFStationEx")]
        public static extern int BS_EnrollUserFStationEx(int handle, IntPtr userHdr, byte[] imageData, byte[] faceTemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollMultipleUserFStation")]
        public static extern int BS_EnrollMultipleUserFStation(int handle, int numOfUser, IntPtr userHdr, byte[] faceTemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_EnrollMultipleUserFStationEx")]
        public static extern int BS_EnrollMultipleUserFStationEx(int handle, int numOfUser, IntPtr userHdr, byte[] imageData, byte[] faceTemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_GetLogCount")]
        public static extern int BS_GetLogCount(int handle, ref int logCount);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadLog")]
        public static extern int BS_ReadLog(int handle, int startTime, int endTime, ref int logCount, IntPtr logRecord);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadLogEx")]
        public static extern int BS_ReadLogEx(int handle, int startTime, int endTime, ref int logCount, IntPtr logRecordEx);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadNextLog")]
        public static extern int BS_ReadNextLog(int handle, int startTime, int endTime, ref int logCount, IntPtr logRecord);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadNextLogEx")]
        public static extern int BS_ReadNextLogEx(int handle, int startTime, int endTime, ref int logCount, IntPtr logRecordEx);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_DeleteLog")]
        public static extern int BS_DeleteLog(int handle, int logCount, ref int deletedCount);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadCardIDEx")]
        public static extern int BS_ReadCardIDEx(int handle, ref uint cardID, ref int customID);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ScanTemplate")]
        public static extern int BS_ScanTemplate(int handle, byte[] templateData);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ScanFaceTemplate")]
        public static extern int BS_ScanFaceTemplate(int handle, IntPtr userTemplateHdr, byte[] imageData, byte[] faceTemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadOPModeConfig")]
        public static extern int BS_ReadOPModeConfig(int handle, IntPtr data);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadDSOPModeConfig")]
        public static extern int BS_ReadDSOPModeConfig(int handle, IntPtr data);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadXSOPModeConfig")]
        public static extern int BS_ReadXSOPModeConfig(int handle, IntPtr data);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadBS2OPModeConfig")]
        public static extern int BS_ReadBS2OPModeConfig(int handle, IntPtr data);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadFaceData")]
        public static extern int BS_ReadFaceData(int handle, ref int imageLen, byte[] imageData, byte[] faceTemplate);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadSpecificImageLog")]
        public static extern int BS_ReadSpecificImageLog(int handle, int eventTime, int eventType, ref int imageLen, byte[] imageData);

        [DllImport("BS_SDK.dll", 
            CharSet = CharSet.Ansi, 
            EntryPoint = "BS_ConvertToUTF8")]
        public static extern int BS_ConvertToUTF8(byte[] msg, byte[] utf8Msg, int limitLen);

        [DllImport("BS_SDK.dll", 
            CharSet = CharSet.Ansi, 
            EntryPoint = "BS_ConvertToUTF16")]
        public static extern int BS_ConvertToUTF16(byte[] msg, byte[] utf16Msg, int limitLen);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_WriteDoorConfig")]
        public static extern int BS_WriteDoorConfig(int handle, IntPtr DoorConfig);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
            EntryPoint = "BS_ReadDoorConfig")]
        public static extern int BS_ReadDoorConfig(int handle, IntPtr DoorConfig);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_AddTimeScheduleEx")]
        public static extern int BS_AddTimeScheduleEx( int handle, IntPtr schedule );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_DeleteTimeScheduleEx")]
        public static extern int BS_DeleteTimeScheduleEx( int handle, int scheduleID );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_DeleteAllTimeScheduleEx")]
        public static extern int BS_DeleteAllTimeScheduleEx( int handle );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_GetAllTimeScheduleEx")]
        public static extern int BS_GetAllTimeScheduleEx( int handle, ref int numOfSchedule, IntPtr schedule );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_SetAllTimeScheduleEx")]
        public static extern int BS_SetAllTimeScheduleEx( int handle, int numOfSchedule, IntPtr schedule );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_AddHolidayEx")]
        public static extern int BS_AddHolidayEx( int handle, IntPtr holiday );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_DeleteHolidayEx")]
        public static extern int BS_DeleteHolidayEx( int handle, int holidayID );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_DeleteAllHolidayEx")]
        public static extern int BS_DeleteAllHolidayEx( int handle );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_GetAllHolidayEx")]
        public static extern int BS_GetAllHolidayEx( int handle, ref int numOfHoliday, IntPtr holiday );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_SetAllHolidayEx")]
        public static extern int BS_SetAllHolidayEx( int handle, int numOfHoliday, IntPtr holiday );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_AddAccessGroupEx")]
        public static extern int BS_AddAccessGroupEx( int handle, IntPtr group );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_DeleteAccessGroupEx")]
        public static extern int BS_DeleteAccessGroupEx( int handle, int groupID );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_DeleteAllAccessGroupEx")]
        public static extern int BS_DeleteAllAccessGroupEx( int handle );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_GetAllAccessGroupEx")]
        public static extern int BS_GetAllAccessGroupEx( int handle, ref int numOfGroup, IntPtr group );

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_SetAllAccessGroupEx")]
        public static extern int BS_SetAllAccessGroupEx(int handle, int numOfGroup, IntPtr group);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
           EntryPoint = "BS_ReadSysInfoConfig")]
        public static extern int BS_ReadSysInfoConfig(int handle, IntPtr SysConfigInfo);

        [DllImport("BS_SDK.dll",
            CharSet = CharSet.Ansi,
          EntryPoint = "BS_EncryptSHA256")]
        public static extern int BS_EncryptSHA256(byte[] input, int length, byte[] output);


        //
        // Structure Declarations
        //
        [ StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct BESysInfoData
		{
            public uint magicNo;
            public int version;
            public uint timestamp;
            public uint checksum;
            [ MarshalAs( UnmanagedType.ByValArray, SizeConst=4 )] 
            public int[] headerReserved;            

            public uint ID;
            [ MarshalAs( UnmanagedType.ByValArray, SizeConst=8 )] 
            public byte[] macAddr;
            [ MarshalAs( UnmanagedType.ByValArray, SizeConst=16 )] 
            public byte[] boardVer;
            [ MarshalAs( UnmanagedType.ByValArray, SizeConst=16 )] 
            public byte[] firmwareVer;
            [ MarshalAs( UnmanagedType.ByValArray, SizeConst=40 )] 
            public int[] reserved;
		};

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BESysInfoDataBLN
        {
            public uint magicNo;
            public int version;
            public uint timestamp;
            public uint checksum;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] headerReserved;

            public uint ID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] macAddr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] boardVer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] firmwareVer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] productName;
            public int language;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 31)]
            public int[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSSysInfoConfig
        {
            public uint ID;
            
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] macAddr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] productName;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] boardVer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] firmwareVer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] blackfinVer;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] kernelVer;

            public int language;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSHolidayElemEx 
        {
	        enum enumBSHolidayElemEx
            {
		        // flag
		        ONCE = 0x01,
	        };

            public byte flag;
            public byte year; // since 2000
            public byte month; // 1 ~ 12
            public byte startDay; // 1 ~ 31
            public byte duration; // 1 ~ 100
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSHolidayEx {
	        enum enumBSHolidayEx
            {
		        MAX_HOLIDAY = 32,
	        };

	        public int holidayID; // 1 ~ 32
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	        public byte[] name;
	        public int numOfHoliday;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	        public BSHolidayElemEx[] holiday;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	        public int[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct  BSTimeCodeElemEx 
        {
	        public ushort startTime;
	        public ushort endTime;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSTimeCodeEx 
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
	        public BSTimeCodeElemEx[] codeElement;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSTimeScheduleEx 
        {
	        enum enumBSTimeScheduleEx
            {
		        // pre-defined schedule
		        NO_TIME_SCHEDULE	= 0xFD,
		        ALL_TIME_SCHEDULE 	= 0xFE,

		        NUM_OF_DAY		= 9,
		        NUM_OF_HOLIDAY	= 2,

		        SUNDAY 		= 0,
		        MONDAY		= 1,
		        TUESDAY		= 2,
		        WEDNESDAY	= 3,
		        THURSDAY	= 4,
		        FRIDAY		= 5,
		        SATURDAY	= 6,
		        HOLIDAY1	= 7,
		        HOLIDAY2	= 8,
	        };

	        public int scheduleID; // 1 ~ 128
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	        public int[] holiday; // 0 for unused
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
	        public BSTimeCodeEx[] timeCode; // 0 - Sunday, 1 - Monday, ...
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	        public int[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSAccessGroupEx
        {
	        enum enumBSAccessGroupEx
            {
                // AC group type
                NORMAL = 0x00,
                CUSTOM = 0x01,

                // pre-defined group
		        NO_ACCESS_GROUP		= 0xFD,
		        FULL_ACCESS_GROUP	= 0xFE,

		        // pre-defined door
		        ALL_DOOR		= 0x00,

		        MAX_READER = 32,
	        };

	        public int groupID; // 1 ~ 128
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] name;
	        public int numOfReader;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	        public uint[] readerID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	        public int[] scheduleID;
            public int type;
            public uint userID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	        public int[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSDoor
        {
            public enum BSDOOR
            {
                // device id
                BS_DEVICE_HOST	= 0x00,
                BS_DEVICE_SLAVE	= 0x01,
                BS_DEVICE_SECUREIO0	= 0x02,
                BS_DEVICE_SECUREIO1	= 0x03,
                BS_DEVICE_SECUREIO2	= 0x04,
                BS_DEVICE_SECUREIO3	= 0x05,

                BS_DEVICE_ALL = 0xFF,

                // input port id
                BS_PORT_INPUT0	= 0x00,
                BS_PORT_INPUT1	= 0x01,
                BS_PORT_INPUT2	= 0x02,
                BS_PORT_INPUT3	= 0x03,
                BS_PORT_TAMPER	= 0x04,

                // relay id
                BS_PORT_RELAY0	= 0x00,
                BS_PORT_RELAY1	= 0x01,

                // relay
                RELAY_DISABLED = 0xFFFF,
                HOST_RELAY = (BS_DEVICE_HOST << 8) | BS_PORT_RELAY0,
                HOST_RELAY0 = (BS_DEVICE_HOST << 8) | BS_PORT_RELAY0,
                HOST_RELAY1 = (BS_DEVICE_HOST << 8) | BS_PORT_RELAY1,
                SLAVE_RELAY = (BS_DEVICE_SLAVE << 8) | BS_PORT_RELAY0,
                SLAVE_RELAY0 = (BS_DEVICE_SLAVE << 8) | BS_PORT_RELAY0,
                SLAVE_RELAY1 = (BS_DEVICE_SLAVE << 8) | BS_PORT_RELAY1,
                SECUREIO0_RELAY0 = (BS_DEVICE_SECUREIO0 << 8) | BS_PORT_RELAY0,
                SECUREIO0_RELAY1 = (BS_DEVICE_SECUREIO0 << 8) | BS_PORT_RELAY1,
                SECUREIO1_RELAY0 = (BS_DEVICE_SECUREIO1 << 8) | BS_PORT_RELAY0,
                SECUREIO1_RELAY1 = (BS_DEVICE_SECUREIO1 << 8) | BS_PORT_RELAY1,
                SECUREIO2_RELAY0 = (BS_DEVICE_SECUREIO2 << 8) | BS_PORT_RELAY0,
                SECUREIO2_RELAY1 = (BS_DEVICE_SECUREIO2 << 8) | BS_PORT_RELAY1,
                SECUREIO3_RELAY0 = (BS_DEVICE_SECUREIO3 << 8) | BS_PORT_RELAY0,
                SECUREIO3_RELAY1 = (BS_DEVICE_SECUREIO3 << 8) | BS_PORT_RELAY1,

                // RTE
                HOST_INPUT0 = (BS_DEVICE_HOST << 8) | BS_PORT_INPUT0,
                SLAVE_INPUT0 = (BS_DEVICE_SLAVE << 8) | BS_PORT_INPUT0,
                SECUREIO0_RTE0 = (BS_DEVICE_SECUREIO0 << 8) | BS_PORT_INPUT0,
                SECUREIO0_RTE1 = (BS_DEVICE_SECUREIO0 << 8) | BS_PORT_INPUT2,
                SECUREIO1_RTE0 = (BS_DEVICE_SECUREIO1 << 8) | BS_PORT_INPUT0,
                SECUREIO1_RTE1 = (BS_DEVICE_SECUREIO1 << 8) | BS_PORT_INPUT2,
                SECUREIO2_RTE0 = (BS_DEVICE_SECUREIO2 << 8) | BS_PORT_INPUT0,
                SECUREIO2_RTE1 = (BS_DEVICE_SECUREIO2 << 8) | BS_PORT_INPUT2,
                SECUREIO3_RTE0 = (BS_DEVICE_SECUREIO3 << 8) | BS_PORT_INPUT0,
                SECUREIO3_RTE1 = (BS_DEVICE_SECUREIO3 << 8) | BS_PORT_INPUT2,

                // Door Sensor
                HOST_INPUT1 = (BS_DEVICE_HOST << 8) | BS_PORT_INPUT1,
                SLAVE_INPUT1 = (BS_DEVICE_SLAVE << 8) | BS_PORT_INPUT1,
                SECUREIO0_DOOR_SENSOR0 = (BS_DEVICE_SECUREIO0 << 8) | BS_PORT_INPUT1,
                SECUREIO0_DOOR_SENSOR1 = (BS_DEVICE_SECUREIO0 << 8) | BS_PORT_INPUT3,
                SECUREIO1_DOOR_SENSOR0 = (BS_DEVICE_SECUREIO1 << 8) | BS_PORT_INPUT1,
                SECUREIO1_DOOR_SENSOR1 = (BS_DEVICE_SECUREIO1 << 8) | BS_PORT_INPUT3,
                SECUREIO2_DOOR_SENSOR0 = (BS_DEVICE_SECUREIO2 << 8) | BS_PORT_INPUT1,
                SECUREIO2_DOOR_SENSOR1 = (BS_DEVICE_SECUREIO2 << 8) | BS_PORT_INPUT3,
                SECUREIO3_DOOR_SENSOR0 = (BS_DEVICE_SECUREIO3 << 8) | BS_PORT_INPUT1,
                SECUREIO3_DOOR_SENSOR1 = (BS_DEVICE_SECUREIO3 << 8) | BS_PORT_INPUT3,

                HOST_INPUT2 = (BS_DEVICE_HOST << 8) | BS_PORT_INPUT2,
                HOST_INPUT3 = (BS_DEVICE_HOST << 8) | BS_PORT_INPUT3,

                // Generic definition for extended 485 configuration
                SECUREIO0_INPUT0 = (BS_DEVICE_SECUREIO0 << 8) | BS_PORT_INPUT0,
                SECUREIO0_INPUT1 = (BS_DEVICE_SECUREIO0 << 8) | BS_PORT_INPUT1,
                SECUREIO0_INPUT2 = (BS_DEVICE_SECUREIO0 << 8) | BS_PORT_INPUT2,
                SECUREIO0_INPUT3 = (BS_DEVICE_SECUREIO0 << 8) | BS_PORT_INPUT3,
                SECUREIO1_INPUT0 = (BS_DEVICE_SECUREIO1 << 8) | BS_PORT_INPUT0,
                SECUREIO1_INPUT1 = (BS_DEVICE_SECUREIO1 << 8) | BS_PORT_INPUT1,
                SECUREIO1_INPUT2 = (BS_DEVICE_SECUREIO1 << 8) | BS_PORT_INPUT2,
                SECUREIO1_INPUT3 = (BS_DEVICE_SECUREIO1 << 8) | BS_PORT_INPUT3,
                SECUREIO2_INPUT0 = (BS_DEVICE_SECUREIO2 << 8) | BS_PORT_INPUT0,
                SECUREIO2_INPUT1 = (BS_DEVICE_SECUREIO2 << 8) | BS_PORT_INPUT1,
                SECUREIO2_INPUT2 = (BS_DEVICE_SECUREIO2 << 8) | BS_PORT_INPUT2,
                SECUREIO2_INPUT3 = (BS_DEVICE_SECUREIO2 << 8) | BS_PORT_INPUT3,
                SECUREIO3_INPUT0 = (BS_DEVICE_SECUREIO3 << 8) | BS_PORT_INPUT0,
                SECUREIO3_INPUT1 = (BS_DEVICE_SECUREIO3 << 8) | BS_PORT_INPUT1,
                SECUREIO3_INPUT2 = (BS_DEVICE_SECUREIO3 << 8) | BS_PORT_INPUT2,
                SECUREIO3_INPUT3 = (BS_DEVICE_SECUREIO3 << 8) | BS_PORT_INPUT3,

                // Open Event
                ALL_EVENT = 0x00,
                AUTH_ONLY = 0x01,
                TNA_ONLY = 0x02,
                AUTH_N_TNA = 0x03,
                NONE = 0x04,

                // Door/switch type
                NORMALLY_OPEN = 0x00,
                NORMALLY_CLOSED = 0x01,

                // Reader
                NO_READER = 0x00,
                HOST_READER = 0x01,
                SLAVE_READER = 0x02,
            };

            public int relay;
            public int useRTE;
            public int useDoorSensor;
            public int openEvent; // only for BST
            public int openTime;
            public int heldOpenTime;
            public int forcedOpenSchedule;
            public int forcedCloseSchedule;
            public int RTEType;
            public int sensorType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public short[] reader;
            public byte useRTEEx;
            public byte useSoundForcedOpen;
            public byte useSoundHeldOpen;
            public byte openOnce;
            public int RTE;
            public byte useDoorSensorEx;
            public byte alarmStatus;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] reserved2;
            public int doorSensor;
            public int relayDeviceId;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSDoorConfig
        {
            public enum BSDOORCONFIG
            {
                MAX_DOOR = 2,

                // Door mode
                NO_DOOR = 0,
                ONE_DOOR = 1,
                TWO_DOOR = 2,
            };

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	        public BSDoor[] door;
            public int apbType;
            public int apbResetTime;
            public int doorMode;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSInputFunction
        {
            public int functionType;
            public short minimumDuration;
            public short switchType;
            public int timeSchedule;
            public uint deviceID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSInputConfig
        {
	        // host inputs
            public BSInputFunction hostTamper;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	        public BSInputFunction[] hostInput;

	        // secure I/O
	        //BSInputFunction secureIO[4][4];
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public BSInputFunction[] secureIO;

	        // slave
	        public BSInputFunction slaveTamper;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	        public BSInputFunction[] slaveInput;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSOutputEvent
        {
	        public uint nevent; // (8 bit input device ID << 16) | 16 bit event ID 
	        public byte outputDeviceID;
	        public byte outputRelayID;
	        public byte relayOn;
	        public  byte reserved1;
	        public ushort delay;
	        public ushort high;
	        public ushort low;
	        public ushort count;
	        public int priority; // 1(highest) ~ 99(lowest)
	        public uint deviceID;
	        public int outputType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
	        public int[] reserved2;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSEMOutputEvent
        {
            public ushort inputType;
            public ushort outputRelayID;
            public ushort inputDuration;
            public ushort high;
            public ushort low;
            public ushort count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public int[] reserved3;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSOutputConfig
        {
            public int numOfEvent;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200 - 16)]
            public BSOutputEvent[] outputEvent;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public BSEMOutputEvent[] emergencyEvent;
	        //BSEMOutputEvent emergencyEvent[BSInputConfig::NUM_OF_SECURE_IO][BSInputConfig::NUM_OF_SECURE_INPUT];

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 31)]
            public int[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BECommandCard
        {
            public uint cardID;
            public byte customID;
            public byte commandType;
            public byte needAdminFinger;
            public byte reserved;
            public uint fullCardCustomID;
        };

        public enum BS_WIEGAND_FORMAT
        {
            BS_WIEGAND_26BIT = 0x01,
            BS_WIEGAND_PASS_THRU = 0x02,
            BS_WIEGAND_CUSTOM = 0x03,
        };

        public enum BS_WIEGAND_PARITY_TYPE
        {
            BS_WIEGAND_EVEN_PARITY = 0,
            BS_WIEGAND_ODD_PARITY = 1,
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSWiegandField
        {
            public int bitIndex;
            public int bitLength;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSWiegandParity
        {
            public int bitIndex;
            public BS_WIEGAND_PARITY_TYPE type;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] bitMask;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSWiegandFormatHeader
        {
            public BS_WIEGAND_FORMAT format;
            public int totalBits;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSWiegandPassThruData
        {
            public int numOfIDField;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public BSWiegandField[] field;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSWiegandCustomData
        {
            public int numOfField;
            public uint idFieldMask;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public BSWiegandField[] field;
            public int numOfParity;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public BSWiegandParity[] parity;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSWiegandFormatData
        {
	        //BSWiegandPassThruData	passThruData;
            public BSWiegandCustomData customData;
        };

        /*
        typedef union {
	        BSWiegandPassThruData	passThruData;
	        BSWiegandCustomData		customData;
        } BSWiegandFormatData;
        */

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSWiegandConfig
        {
            public uint outWidth;
            public uint outInterval;
            public BSWiegandFormatHeader header;
            public BSWiegandFormatData data;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public uint[] fieldValue;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BEOutputPattern
        {
	        public enum OUTPUTPATTERN
            {
		        MAX_ARG = 3,

		        // LED color
		        RED = 0x00,
    	        YELLOW,
		        GREEN,
		        CYAN,
		        BLUE,
		        MAGENTA,
		        WHITE,

		        FADEOUT = 0x01000000,

		        // Buzzer frequency
		        HIGH_FREQ = 3136,
		        MIDDLE_FREQ = 2637,
		        LOW_FREQ = 2093,
	        };

	        public int repeat; // 0: indefinite, -1: don't user
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] arg; // color for LED, frequency for Buzzer, -1 for last 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] high; // msec
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] low; // msec
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BEOutputPatternBLN
        {
            public enum OUTPUTPATTERNBLN
            {
                MAX_ARG = 3,

                // Priority
                NORMAL = 0,
                HIGH = 1,

                // LED color
                RED = 0x00,
                YELLOW,
                GREEN,
                CYAN,
                BLUE,
                MAGENTA,
                WHITE,

                FADEOUT = 0x01000000,

                // Buzzer frequency
                HIGH_FREQ = 3136,
                MIDDLE_FREQ = 2637,
                LOW_FREQ = 2093,

                //LCD LED
                OFF = 0x00,
                ON = 0x01,

                //KEYPAD LED
                NUMERIC = 0x01,
                OK_ARROW = 0x02,
            };

            public int repeat; // 0: indefinite, -1: don't user
            public int priority;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] arg; // color for LED, frequency for Buzzer, -1 for last 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] high; // msec
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public short[] low; // msec
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BELEDBuzzerConfig
        {
	        enum LEDDEFINE
            {
		        MAX_SIGNAL	= 48,

		        //
		        // Signal Index
		        //
        		
		        //  STATUS
		        STATUS_NORMAL			= 0x00,
		        STATUS_LOCKED,			
		        STATUS_TAMPER_ON,		
		        STATUS_RTC_ERROR,		
		        STATUS_WAITING_INPUT,	
		        STATUS_WAITING_DHCP,
		        STATUS_DHCP_FAILED,
		        STATUS_WRONG_CRYPT,
                STATUS_ARMED,

		        // Misc. Event
		        SCAN_FINGER			= 0x0C,
		        SCAN_CARD,

		        // Output Event: Same as BSOutputEvent
		        AUTH_SUCCESS		= 0x10,
		        AUTH_FAIL,
		        AUTH_DURESS,
		        ANTI_PASSBACK_FAIL,
		        ACCESS_NOT_GRANTED,
		        ENTRANCE_LIMITATION,
		        ADMIN_AUTH_SUCCESS,

		        TAMPER_ON,			
		        DOOR_OPEN,			
		        DOOR_CLOSED,		
		        DOOR_FORCED_OPEN,	
		        DOOR_HELD_OPEN_WARNING,

		        INPUT0_ON,
		        INPUT1_ON,
		        INPUT2_ON,
		        INPUT3_ON,

                ARM,
                DISARM, 

                ALARM_ON,

		        // Generic Event
		        GENERIC_SUCCESS = 0x2A,
		        GENERIC_FAIL,

		        ARM_DISARM_READY,
	        };

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] reserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public BEOutputPattern[] ledPattern;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public BEOutputPattern[] buzzerPattern;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public ushort[] signalReserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BELEDBuzzerConfigBLN
        {
            enum LEDDEFINEBLN
            {
                MAX_SIGNAL = 50,

                //
                // Signal Index
                //

                //  STATUS
                STATUS_NORMAL = 0x00,
                STATUS_LOCKED,
                STATUS_TAMPER_ON,
                STATUS_RTC_ERROR,
                STATUS_WAITING_INPUT,
                STATUS_WAITING_DHCP,
                STATUS_DHCP_FAILED,
                STATUS_WRONG_CRYPT,
                STATUS_KEY_PRESSED,
                STATUS_ARMED,

                // Misc. Event
                SCAN_FINGER = 0x0C,
                SCAN_CARD,

                LIGHT_ON,
                LIGHT_OFF,

                // Output Event: Same as BSOutputEvent
                AUTH_SUCCESS = 0x10,
                AUTH_FAIL,
                AUTH_DURESS,
                ANTI_PASSBACK_FAIL,
                ACCESS_NOT_GRANTED,
                ENTRANCE_LIMITATION,
                ADMIN_AUTH_SUCCESS,

                TAMPER_ON,
                DOOR_OPEN,
                DOOR_CLOSED,
                DOOR_FORCED_OPEN,
                DOOR_HELD_OPEN_WARNING,
                DOOR_FORCED_OPEN_CLOSED,

                INPUT0_ON,
                INPUT1_ON,
                INPUT2_ON,
                INPUT3_ON,

                ARM,
                DISARM,

                COMM,


                ALARM_ON,
                ALARM_OFF,

                // Generic Event
                GENERIC_SUCCESS = 0x2A,
                GENERIC_FAIL,

                ARM_DISARM_READY,
            };

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] reserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
            public BEOutputPatternBLN[] ledPattern;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
            public BEOutputPatternBLN[] buzzerPattern;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
            public BEOutputPatternBLN[] lcdLedPattern;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
            public BEOutputPatternBLN[] keypadLedPattern;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
            public ushort[] signalReserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BETnaEventConfig
        {
            enum  enumBETnaEventConfig
            {
                MAX_TNA_FUNCTION_KEY = 16,
                MAX_TNA_EVENT_LEN   = 16,
            };

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	        public byte[] enabled;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	        public byte[] useRelay;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public ushort [] key;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 * 16)]
	        public byte[] eventStr;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BETnaEventExConfig
        {
            enum  enumBETnaEventExConfig
            {
                MAX_TNA_FUNCTION_KEY = 16,
            };

	        public int fixedTnaIndex;
	        public int manualTnaIndex;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	        public int[] timeSchedule;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BEConfigData
        {
            // header
            public uint magicNo;
            public int version;
            public uint timestamp;
            public uint checksum;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        	public int[] headerReserved;

	        // operation mode
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	        public int[] opMode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	        public int[] opModeSchedule;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	        public byte[] opDoubleMode;
            public int opModePerUser; /* PROHIBITED, ALLOWED */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
	        public int[] opReserved;

            // ip
            [MarshalAs(UnmanagedType.I1)]
            public bool useDHCP;
            public uint ipAddr;
            public uint gateway;
            public uint subnetMask;
            public uint serverIpAddr;
            public int port;
            [MarshalAs(UnmanagedType.I1)]
            public bool useServer;
            [MarshalAs(UnmanagedType.I1)]
            public bool synchTime;
            public int support100BaseT;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public int[] ipReserved;

           	// fingerprint
	        public int securityLevel;
            public int fastMode;
            public int fingerReserved1;
            public int timeout; // 1 ~ 20 sec
            public int matchTimeout; // Infinite(0) ~ 10 sec
            public int templateType;
            public int fakeDetection;
            [MarshalAs(UnmanagedType.I1)]
            public bool useServerMatching;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	        public int[] fingerReserved;

	        // I/O
	        public BSInputConfig inputConfig;
	        public BSOutputConfig outputConfig;
	        public BSDoorConfig doorConfig;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	        public int[] ioReserved;

	        //extended serial
	        public uint hostID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	        public uint[] slaveIDEx;
            public uint slaveType;    // 0 : BST, 1 : BEPL

	        // serial
	        public int serialMode; 
	        public int serialBaudrate;
	        public byte serialReserved1; 
	        public byte secureIO; // 0x01 - Secure I/O 0, 0x02, 0x04, 0x08
	        public byte useTermination;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
	        public byte[] serialReserved2;
	        public uint slaveID; // 0 for no slave

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
	        public int[] reserved1;

	        // entrance limit
	        public int minEntryInterval; // 0 for no limit
	        public int numOfEntranceLimit; // MAX 4
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	        public int[] maxEntry; // 0 (no limit) ~ 16
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	        public uint[] entryLimitInterval;
            public int bypassGroupId;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
	        public int[] entranceLimitReserved; 

	        // command card
	        public int numOfCommandCard;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	        public BECommandCard[] commandCard;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	        public int[] commandCardReserved;

	        // tna
	        public int tnaMode;
	        public int autoInSchedule;
	        public int autoOutSchedule;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
	        public int[] tnaReserved;

	        // user
	        public int defaultAG;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
	        public int[] userReserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
	        public int[] reserved2;

	        public int isLocked;

	        // wiegand
            [MarshalAs(UnmanagedType.I1)]
	        public bool useWiegandOutput;
	        public int useWiegandInput;
	        public int wiegandMode;
	        public uint wiegandReaderID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
	        public int[] wiegandReserved;
            public int wiegandIdType;
	        public BSWiegandConfig wiegandConfig;

	        // LED/Buzzer
	        public BELEDBuzzerConfig ledBuzzerConfig;
        	
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 38)]
	        public int[] reserved3;

	        public int cardIdFormatType;	/* CARD_ID_FORMAT_NORMAL, CARD_ID_FORMAT_WIEGAND */
	        public int cardIdByteOrder;	/* CARD_ID_MSB, CARD_ID_LSB */
	        public int cardIdBitOrder;		/* CARD_ID_MSB, CARD_ID_LSB */

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 174)]
            public int[] padding;

        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BEConfigDataBLN
        {
            // header
            public uint magicNo;
            public int version;
            public uint timestamp;
            public uint checksum;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] headerReserved;

            // operation mode
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]    //MAX_OPMODE = 5,
            public int[] opMode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]    //MAX_OPMODE = 5,
            public int[] opModeSchedule;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]    //MAX_OPMODE = 5,
            public byte[] opDualMode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] opReserved1;
            public int opModePerUser;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]    //MAX_IDENTIFYMODE = 3,
            public int[] identificationMode;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]    //MAX_IDENTIFYMODE = 3,
            public int[] identificationModeSchedule;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public int[] opReserved2;

            // ip
            [MarshalAs(UnmanagedType.I1)]
            public bool useDHCP;
            public uint ipAddr;
            public uint gateway;
            public uint subnetMask;
            public uint serverIpAddr;
            public int port;
            [MarshalAs(UnmanagedType.I1)]
            public bool useServer;
            [MarshalAs(UnmanagedType.I1)]
            public bool synchTime;
            public int support100BaseT;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public int[] ipReserved;

            // fingerprint
            public int imageQuality;
            public int securityLevel;
            public int fastMode;
            public int fingerReserved1;
            public int timeout; // 1 ~ 20 sec
            public int matchTimeout; // Infinite(0) ~ 10 sec
            public int templateType;
            public int fakeDetection;
            [MarshalAs(UnmanagedType.I1)]
            public bool useServerMatching;
            [MarshalAs(UnmanagedType.I1)]
            public bool useCheckDuplicate;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public int[] fingerReserved2;

            // I/O
            public BSInputConfig inputConfig;
            public BSOutputConfig outputConfig;
            public BSDoorConfig doorConfig;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] ioReserved;

            //extended serial
            public uint hostID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]    //MAX_485_DEVICE = 8,
            public uint[] slaveIDEx;
            public uint slaveType;    // 0 : BST, 1 : BEPL

            // serial
            public int serialMode;
            public int serialBaudrate;
            public byte serialReserved1;
            public byte secureIO; // 0x01 - Secure I/O 0, 0x02, 0x04, 0x08
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] serialReserved2;
            public uint slaveID; // 0 for no slave

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
            public int[] reserved1;

            // entrance limit
            public int minEntryInterval; // 0 for no limit
            public int numOfEntranceLimit; // MAX 4
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] maxEntry; // 0 (no limit) ~ 16
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public uint[] entryLimitInterval;
            public int bypassGroupId;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public int[] entranceLimitReserved;

            // command card
            public int numOfCommandCard;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public BECommandCard[] commandCard;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] commandCardReserved;

            // tna
            public int tnaMode;
            public int autoInSchedule;
            public int autoOutSchedule;
            public int tnaChange;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public int[] tnaReserved;

            // user
            public int defaultAG;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public int[] userReserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
            public int[] reserved2;

            public int isLocked;

            // wiegand
            [MarshalAs(UnmanagedType.I1)]
            public bool useWiegandOutput;
            [MarshalAs(UnmanagedType.I1)]
            public bool useWiegandInput;
            public int wiegandMode;
            public uint wiegandReaderID;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] wiegandReserved;
            public int wiegandIdType;
            public BSWiegandConfig wiegandConfig;

            // LED/Buzzer
            public BELEDBuzzerConfigBLN ledBuzzerConfig;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 38)]
            public int[] reserved3;

            public int backlightMode;
            public int soundMode;
            
            public BETnaEventConfig tnaEventConfig;
            public BETnaEventExConfig tnaEventExConfig;
            
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public int[] reserved4;

            public int cardIdFormatType;	/* CARD_ID_FORMAT_NORMAL, CARD_ID_FORMAT_WIEGAND */
            public int cardIdByteOrder;	/* CARD_ID_MSB, CARD_ID_LSB */
            public int cardIdBitOrder;		/* CARD_ID_MSB, CARD_ID_LSB */

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 57)]
            public int[] padding;
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSIPConfig
        {
            public int lanType;
            [MarshalAs(UnmanagedType.I1)]
            public bool useDHCP;
            public uint port;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	        public byte[] ipAddr;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	        public byte[] gateway;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	        public byte[] subnetMask;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	        public byte[] serverIP;

            public int maxConnection;
            [MarshalAs(UnmanagedType.I1)]
            public bool useServer;
            public uint serverPort;
            [MarshalAs(UnmanagedType.I1)]
            public bool syncTimeWithServer;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
	        public byte[] reserved;
        }

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BEUserHdr
        {
            public int version;
            public uint userID;

            public int startTime;
            public int expiryTime;

            public uint cardID;
            public byte cardCustomID;
            public byte commandCardFlag;
            public byte cardFlag;
            public byte cardVersion;

            public ushort adminLevel;
            public ushort securityLevel;

            public uint accessGroupMask;

            public ushort numOfFinger;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public ushort[] fingerChecksum;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] isDuress;

            public int disabled;
            public int opMode;
            public int dualMode;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] password;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
            public int[] reserved2;
        };


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSUserHdrEx
        {
            public uint ID;

            public ushort headerVersion;
	        public ushort adminLevel;
	        public ushort securityLevel;
	        public ushort statusMask; 
	        public uint accessGroupMask;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public byte[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
            public byte[] department;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 17)]
            public byte[] password;

	        public ushort numOfFinger;
	        public ushort duressMask;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public ushort[] checksum; // index 0, 1

	        public ushort authMode; 
	        public ushort authLimitCount; // 0 for no limit 
	        public ushort reserved; 
	        public ushort timedAntiPassback; // in minutes. 0 for no limit 
	        public uint cardID; // 0 for not used
	        public byte	bypassCard;
	        public byte	disabled;
	        public uint expireDateTime;
	        public int customID; //card Custom ID
	        public int version; // card Info Version
            public uint startDateTime; 
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct DSUserHdr
        {
	        public enum ENUM
	        {
		        DS_MAX_NAME_LEN = 48,
		        DS_MAX_PASSWORD_LEN = 16,
		        DS_MIN_PASSWORD_LEN = 4,
        		
		        DS_TEMPLATE_SIZE = 384,
		        DS_FACE_TEMPLATE_SIZE = 2284,

		        MAX_FINGER = 10,
		        MAX_FINGER_TEMPLATE = 20,
		        MAX_FACE = 5,
       	        MAX_FACE_TEPLATE = 5,

                USER_ADMIN = 1,
                USER_NORMAL = 0,
	        };

            public uint ID;

            public ushort headerVersion;
            public ushort adminLevel;
            public ushort securityLevel;
            public ushort statusMask;
            public uint accessGroupMask;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public ushort[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public ushort[] department;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public ushort[] password;

            public ushort numOfFinger;
            public ushort numOfFace;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] duress;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] fingerType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] reserved1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public uint[] fingerChecksum;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public uint[] faceChecksum;
 
            public ushort authMode;
            public byte bypassCard;
            public byte disabled;

            public uint cardID;   //card ID
            public uint customID; //card Custom ID

            public uint startDateTime;
            public uint expireDateTime;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public uint[] reserved2;

        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct XSUserHdr
        {
	        public enum ENUM
	        {
		        DS_MAX_NAME_LEN = 48,
		        DS_MAX_PASSWORD_LEN = 16,
		        DS_MIN_PASSWORD_LEN = 4,
        		
		        DS_TEMPLATE_SIZE = 384,
		        DS_FACE_TEMPLATE_SIZE = 2284,

		        MAX_FINGER = 10,
		        MAX_FINGER_TEMPLATE = 20,
		        MAX_FACE = 5,
       	        MAX_FACE_TEPLATE = 5,

                USER_ADMIN = 1,
                USER_NORMAL = 0,
	        };

            public uint ID;

            public ushort headerVersion;
            public ushort adminLevel;
            public ushort securityLevel;
            public ushort statusMask;
            public uint accessGroupMask;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public ushort[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public ushort[] department;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public ushort[] password;

            public ushort numOfFinger;
            public ushort numOfFace;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] duress;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] fingerType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] reserved1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public uint[] fingerChecksum;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public uint[] faceChecksum;

            public ushort authMode;
            public byte bypassCard;
            public byte disabled;

            public uint cardID;   //card ID
            public uint customID; //card Custom ID

            public uint startDateTime;
            public uint expireDateTime;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public uint[] reserved2;

        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BS2UserHdr
        {
	        public enum ENUM
	        {
		        DS_MAX_NAME_LEN = 48,
		        DS_MAX_PASSWORD_LEN = 16,
		        DS_MIN_PASSWORD_LEN = 4,
        		
		        DS_TEMPLATE_SIZE = 384,
		        DS_FACE_TEMPLATE_SIZE = 2284,

		        MAX_FINGER = 10,
		        MAX_FINGER_TEMPLATE = 20,
		        MAX_FACE = 5,
       	        MAX_FACE_TEPLATE = 5,

                USER_ADMIN = 1,
                USER_NORMAL = 0,
	        };

            public uint ID;

            public ushort headerVersion;
            public ushort adminLevel;
            public ushort securityLevel;
            public ushort statusMask;
            public uint accessGroupMask;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public ushort[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public ushort[] department;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public ushort[] password;

            public ushort numOfFinger;
            public ushort numOfFace;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] duress;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] reserved;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public byte[] fingerType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] reserved1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public uint[] fingerChecksum;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public uint[] faceChecksum;

            public ushort authMode;
            public byte bypassCard;
            public byte disabled;

            public uint cardID;   //card ID
            public uint customID; //card Custom ID

            public uint startDateTime;
            public uint expireDateTime;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public uint[] reserved2;

        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct FSUserHdr
        {
	        public enum ENUM {		
	            MAX_NAME_LEN	= 48,	
	            MAX_PASSWORD_LEN	= 16,	
	            MIN_PASSWORD_LEN	= 4,	
            			
	            MAX_FACE	= 25,	
	            FACE_TEMPLATE_SIZE	= 2000,	
	            MAX_FACE_RAW	= 20,	
	            FACE_RAW_TEMPLATE_SIZE	= 37500,	
	            MAX_IMAGE_SIZE	= 8*1024,	
                    			
	            USER_NORMAL	= 0,	
	            USER_ADMIN	= 1,	
            			
	            USER_SECURITY_DEFAULT	= 0,	
	            USER_SECURITY_LOWER	= 1,	
	            USER_SECURITY_LOW	= 2,	
	            USER_SECURITY_NORMAL	= 3,	
	            USER_SECURITY_HIGH	= 4,	
	            USER_SECURITY_HIGHER	= 5,	
	        };

            public uint ID;
            public ushort headerVersion;
            public ushort adminLevel;
            public ushort securityLevel;
            public ushort statusMask;
            public uint accessGroupMask;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public ushort[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public ushort[] department;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public ushort[] password;

            public ushort numOfFace;
            public ushort numOfUpdatedFace;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public ushort[] faceLen;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] faceTemp;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public uint[] faceChecksum;

            public ushort authMode;
            public byte bypassCard;
            public byte disabled;

            public uint cardID;   //card ID
            public uint customID; //card Custom ID

            public uint startDateTime;
            public uint expireDateTime;

            public ushort faceUpdatedIndex;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
            public ushort[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct FSUserHdrEx
        {
            public enum ENUM
            {
                MAX_NAME_LEN = 48,
                MAX_PASSWORD_LEN = 16,
                MIN_PASSWORD_LEN = 4,

                MAX_FACE_TYPE = 5,
                MAX_FACE = 25,
                FACE_TEMPLATE_SIZE = 2000,
                MAX_FACE_RAW = 20,
                FACE_RAW_TEMPLATE_SIZE = 37500,
                MAX_IMAGE_SIZE = 8 * 1024,

                USER_NORMAL = 0,
                USER_ADMIN = 1,

                USER_SECURITY_DEFAULT = 0,
                USER_SECURITY_LOWER = 1,
                USER_SECURITY_LOW = 2,
                USER_SECURITY_NORMAL = 3,
                USER_SECURITY_HIGH = 4,
                USER_SECURITY_HIGHER = 5,
            };

            public uint ID;
            public ushort headerVersion;
            public ushort adminLevel;
            public ushort securityLevel;
            public ushort statusMask;
            public uint accessGroupMask;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public ushort[] name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public ushort[] department;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public ushort[] password;

            public ushort numOfFaceType;    //0~5
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public ushort [] numOfFace;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public ushort[] numOfUpdatedFace;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 125)]
            public ushort[] faceLen;    //[5][25]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 125)]
            public uint[] faceChecksum; //[5][25]
             [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public ushort[] faceUpdatedIndex;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public ushort[] faceStillcutLen;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public ushort[] faceTemp;

            public ushort authMode;
            public byte bypassCard;
            public byte disabled;

            public uint cardID;   //card ID
            public uint customID; //card Custom ID

            public uint startDateTime;
            public uint expireDateTime;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
            public uint[] reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct FSUserTemplateHdr
        {
            public ushort imageSize;

            public ushort numOfFace;
            public ushort numOfUpdatedFace;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 25)]
            public ushort[] faceLen;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] faceTemp;
            public ushort numOfRawFace;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public uint[] rawfaceLen;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSLogRecord
        {
            public byte eventType;
            public byte subEvent;
            public ushort tnaEvent;
            public int eventTime;
            public uint userID;
            public uint reserved;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSLogRecordEx
        {
            public byte eventType;
            public byte subEvent;
            public ushort tnaEvent;
            public int eventTime;
            public uint userID;
            public uint deviceID;
            public ushort imageSlot; // NO_IMAGE for no image, WRITE_ERROR for error
            public ushort reserved1;
            int reserved2;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSImageLogHdr
        {
            public byte eventType;
            public byte subEvent;
            public ushort reserved1;
            public int eventTime;
            public uint userID;
            public uint imageSize;
            public uint deviceID;
            public uint reserved2;
        };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BSOPModeConfig
        {
            public int authMode;
            public int identificationMode;
            public int tnaMode;
            public int tnaChange;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] authSchedule;
            public byte identificationSchedule;
            [MarshalAs(UnmanagedType.I1)]
            public bool dualMode;
            public byte dualSchedule;
            public byte version;
            public ushort cardMode;
            [MarshalAs(UnmanagedType.I1)]
            public bool useFastIDMatching;
            public byte cardIdFormatType;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public byte[] authScheduleEx;
            [MarshalAs(UnmanagedType.I1)]
            public bool usePrivateAuthMode;
            public byte cardIdByteOrder;
            public byte cardIdBitOrder;
        } ;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct DSOPModeConfig
        {
            public int identificationMode;
            public int tnaMode;
            public int tnaChange;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] authSchedule;
            public byte identificationSchedule;
            public byte dualSchedule;
	        public byte usePrivateAuthMode;
	        public byte cardIdFormatType;

	        public byte cardIdByteOrder;
	        public byte cardIdBitOrder;
            public byte enhancedMode;
	        public byte fusionType;

	        public byte fusionTimeout;
	        public byte useDetectFace;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 82)]
	        public byte[] reserved;
        } ;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct XSOPModeConfig
        {
            public byte reserved1;
            public byte tnaMode;
            public byte tnaChange;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] authSchedule;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] reserved2;
            public byte dualSchedule;
	        public byte usePrivateAuthMode;
	        public byte cardIdFormatType;

	        public byte cardIdByteOrder;
	        public byte cardIdBitOrder;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] reserved3;

  	        public byte useDetectFace;
            public byte useServerMatching;
            public byte matchTimeout;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
	        public byte[] reserved;
        } ;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct BS2OPModeConfig
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
            public byte[] fingerAuthSchedule;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] cardAuthSchedule;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] idAuthSchedule;

            public byte tnaMode;
            public byte cardMode;
            public byte dualSchedule;
            public byte usePrivateAuthMode;
            public byte cardIdFormatType;

            public byte cardIdByteOrder;
            public byte cardIdBitOrder;
            public byte useDetectFace;
            public byte useServerMatching;
            public byte matchTimeout;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 77)]
            public byte[] reserved;
        } ;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct FSOPModeConfig
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] faceAuthSchedule;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] cardAuthSchedule;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] idAuthSchedule;

            public byte tnaMode;
            public byte cardMode;
            public byte dualSchedule;
            public byte usePrivateAuthMode;
            public byte cardIdFormatType;

            public byte cardIdByteOrder;
            public byte cardIdBitOrder;
            public byte useDetectFace;
            public byte useServerMatching;
            public byte matchTimeout;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 77)]
            public byte[] reserved;
        } ;

        // 
        // Constants
        //
        public const int BS_SUCCESS = 0;
        public const int BS_ERR_NOT_FOUND = -306;

        public const int BS_DEVICE_BIOSTATION = 0;
        public const int BS_DEVICE_BIOENTRY_PLUS = 1;
        public const int BS_DEVICE_BIOLITE = 2;
		public const int BS_DEVICE_XPASS = 3;
        public const int BS_DEVICE_DSTATION = 4;
        public const int BS_DEVICE_XSTATION = 5;
        public const int BS_DEVICE_BIOSTATION2 = 6;
        public const int BS_DEVICE_XPASS_SLIM = 7;
        public const int BS_DEVICE_FSTATION = 10;
        public const int BS_DEVICE_BIOENTRY_W = 11;
        
        public const int BEPLUS_CONFIG = 0x50;
        public const int BEPLUS_CONFIG_SYS_INFO = 0x51;
        public const int BEPLUS_CONFIG_CARD_READER = 0x53;

        public const int BIOLITE_CONFIG = 0x70;
        public const int BIOLITE_CONFIG_SYS_INFO = 0x71;
        public const int BIOLITE_CONFIG_CARD_READER = 0x72;

        public const int BS_CONFIG_SYS_INFO = 0x41;
        public const int BS_CONFIG_TCPIP = 0x10;

        public const int NO_ACCESS_GROUP = 0xFD;
        public const int FULL_ACCESS_GROUP = 0xFE;

        public const int BS_AUTH_MODE_DISABLED      = 0;
        public const int BS_AUTH_FINGER_ONLY		= 1020;
        public const int BS_AUTH_FINGER_N_PASSWORD	= 1021;
        public const int BS_AUTH_FINGER_OR_PASSWORD	= 1022;
        public const int BS_AUTH_PASS_ONLY			= 1023;
        public const int BS_AUTH_CARD_ONLY          = 1024;


	    //Private Auth
	    public const int PAUTH_FACE_ONLY        = 0;
	    public const int PAUTH_FACE_PIN         = 1;
	    public const int PAUTH_CARD_ONLY        = 2;
	    public const int PAUTH_CARD_PIN         = 3;
	    public const int PAUTH_CARD_FACE        = 4;
	    public const int PAUTH_CARD_FACE_PIN    = 5;
	    public const int PAUTH_CARD_FACE_N_PIN  = 6;
	    public const int PAUTH_ID_PIN           = 7;
	    public const int PAUTH_ID_FACE          = 8;
	    public const int PAUTH_ID_FACE_PIN      = 9;
	    public const int PAUTH_ID_FACE_N_PIN    = 10;
	    public const int PAUTH_FACE_KEY         = 11;
        public const int PAUTH_FACE_PIN_KEY     = 12;
        
        public const int BE_CARD_VERSION_1 = 0x13;

        // user levels for BioStation
        public const int BS_USER_ADMIN = 240;
        public const int BS_USER_NORMAL = 241;

        // security levels for BioStation
        public const int BS_USER_SECURITY_DEFAULT   = 260;
        public const int BS_USER_SECURITY_LOWER     = 261;
        public const int BS_USER_SECURITY_LOW       = 262;
        public const int BS_USER_SECURITY_NORMAL    = 263;
        public const int BS_USER_SECURITY_HIGH      = 264;
        public const int BS_USER_SECURITY_HIGHER    = 265;

        // log events
        public const int BE_EVENT_SCAN_SUCCESS 	= 0x58;
        public const int BE_EVENT_ENROLL_BAD_FINGER = 0x16;
        public const int BE_EVENT_ENROLL_SUCCESS = 0x17;
        public const int BE_EVENT_ENROLL_FAIL = 0x18;
        public const int BE_EVENT_ENROLL_CANCELED = 0x19;

        public const int BE_EVENT_VERIFY_BAD_FINGER = 0x26;
        public const int BE_EVENT_VERIFY_SUCCESS = 0x27;
        public const int BE_EVENT_VERIFY_FAIL = 0x28;
        public const int BE_EVENT_VERIFY_CANCELED = 0x29;
        public const int BE_EVENT_VERIFY_NO_FINGER = 0x2a;

        public const int BE_EVENT_IDENTIFY_BAD_FINGER = 0x36;
        public const int BE_EVENT_IDENTIFY_SUCCESS = 0x37;
        public const int BE_EVENT_IDENTIFY_FAIL = 0x38;
        public const int BE_EVENT_IDENTIFY_CANCELED = 0x39;
        public const int BE_EVENT_IDENTIFY_FINGER = 0x3a;
        public const int BE_EVENT_IDENTIFY_FINGER_PIN = 0x3b;

        public const int BE_EVENT_DELETE_BAD_FINGER = 0x46;
        public const int BE_EVENT_DELETE_SUCCESS = 0x47;
        public const int BE_EVENT_DELETE_FAIL = 0x48;
        public const int BE_EVENT_DELETE_ALL_SUCCESS = 0x49;

        public const int BE_EVENT_VERIFY_DURESS = 0x62;
        public const int BE_EVENT_IDENTIFY_DURESS = 0x63;

        public const int BE_EVENT_TAMPER_SWITCH_ON = 0x64;
        public const int BE_EVENT_TAMPER_SWITCH_OFF = 0x65;

        public const int BE_EVENT_SYS_STARTED = 0x6a;
        public const int BE_EVENT_IDENTIFY_NOT_GRANTED = 0x6d;
        public const int BE_EVENT_VERIFY_NOT_GRANTED = 0x6e;

        public const int BE_EVENT_IDENTIFY_LIMIT_COUNT = 0x6f;
        public const int BE_EVENT_IDENTIFY_LIMIT_TIME = 0x70;

        public const int BE_EVENT_IDENTIFY_DISABLED = 0x71;
        public const int BE_EVENT_IDENTIFY_EXPIRED = 0x72;

        public const int BE_EVENT_APB_FAIL = 0x73;
        public const int BE_EVENT_COUNT_LIMIT = 0x74;
        public const int BE_EVENT_TIME_INTERVAL_LIMIT 	= 0x75;
        public const int BE_EVENT_INVALID_AUTH_MODE		= 0x76;
        public const int BE_EVENT_EXPIRED_USER			= 0x77;
        public const int BE_EVENT_NOT_GRANTED			= 0x78;

        public const int BE_EVENT_DETECT_INPUT0	= 0x54;
        public const int BE_EVENT_DETECT_INPUT1 = 0x55;

        public const int BE_EVENT_TIMEOUT = 0x90;

        public const int BS_EVENT_RELAY_ON	= 0x80;
        public const int BS_EVENT_RELAY_OFF	= 0x81;

        public const int BE_EVENT_DOOR0_OPEN 	= 0x82;
        public const int BE_EVENT_DOOR1_OPEN		= 0x83;
        public const int BE_EVENT_DOOR0_CLOSED 	= 0x84;
        public const int BE_EVENT_DOOR1_CLOSED	= 0x85;

        public const int BE_EVENT_DOOR0_FORCED_OPEN	= 0x86;
        public const int BE_EVENT_DOOR1_FORCED_OPEN	= 0x87;

        public const int BE_EVENT_DOOR0_HELD_OPEN	= 0x88;
        public const int BE_EVENT_DOOR1_HELD_OPEN	= 0x89;

        public const int BE_EVENT_DOOR0_RELAY_ON		= 0x8A;
        public const int BE_EVENT_DOOR1_RELAY_ON		= 0x8B;

        public const int BE_EVENT_INTERNAL_INPUT0	= 0xA0;
        public const int BE_EVENT_INTERNAL_INPUT1	= 0xA1;
        public const int BE_EVENT_SECONDARY_INPUT0	= 0xA2;
        public const int BE_EVENT_SECONDARY_INPUT1	= 0xA3;

        public const int BE_EVENT_SIO0_INPUT0		= 0xB0;
        public const int BE_EVENT_SIO0_INPUT1		= 0xB1;
        public const int BE_EVENT_SIO0_INPUT2		= 0xB2;
        public const int BE_EVENT_SIO0_INPUT3		= 0xB3;

        public const int BE_EVENT_SIO1_INPUT0		= 0xB4;
        public const int BE_EVENT_SIO1_INPUT1		= 0xB5;
        public const int BE_EVENT_SIO1_INPUT2		= 0xB6;
        public const int BE_EVENT_SIO1_INPUT3		= 0xB7;

        public const int BE_EVENT_SIO2_INPUT0		= 0xB8;
        public const int BE_EVENT_SIO2_INPUT1		= 0xB9;
        public const int BE_EVENT_SIO2_INPUT2		= 0xBA;
        public const int BE_EVENT_SIO2_INPUT3		= 0xBB;

        public const int BE_EVENT_SIO3_INPUT0		= 0xBC;
        public const int BE_EVENT_SIO3_INPUT1		= 0xBD;
        public const int BE_EVENT_SIO3_INPUT2		= 0xBE;
        public const int BE_EVENT_SIO3_INPUT3		= 0xBF;

        public const int BE_EVENT_LOCKED			= 0xC0;
        public const int BE_EVENT_UNLOCKED			= 0xC1;

        public const int BE_EVENT_TIME_SET			= 0xD2;
        public const int BE_EVENT_SOCK_CONN         = 0xD3;
        public const int BE_EVENT_SOCK_DISCONN      = 0xD4;
        public const int BE_EVENT_SERVER_SOCK_CONN  = 0xD5;
        public const int BE_EVENT_SERVER_SOCK_DISCONN = 0xD6;
        public const int BE_EVENT_LINK_CONN         = 0xD7;
        public const int BE_EVENT_LINK_DISCONN      = 0xD8;
        public const int BE_EVENT_INIT_IP           = 0xD9;
        public const int BE_EVENT_INIT_DHCP         = 0xDA;
        public const int BE_EVENT_DHCP_SUCCESS      = 0xDB;

        public const int DF_LEN_MAX_IMAGE           = 256 * 1024;

        public const int enumAPBZONETYPE_SOFT       = 1;
        public const int enumAPBZONETYPE_HARD       = 2;

        public const int BS_MAX_HOLIDAY_EX          = 32;
        public const int DF_MAX_TIMESCHEDULE        = 128;
        public const int DF_MAX_ACCESSGROUP         = 128;
        public const int DF_TIMEDATA_CNT            = 5;		// max timecode for each a day

        //TE_SCHEDULE_DAY
        public const int enumWEEKDAY_SUNDAY         = 0;
        public const int enumWEEKDAY_MONDAY         = 1;
        public const int enumWEEKDAY_TUESDAY        = 2;
        public const int enumWEEKDAY_WEDNESDAY      = 3;
        public const int enumWEEKDAY_THURSDAY       = 4;
        public const int enumWEEKDAY_FRIDAY         = 5;
        public const int enumWEEKDAY_SATURDAY       = 6;
        public const int enumWEEKDAY_HOLIDAY1       = 7;
        public const int enumWEEKDAY_HOLIDAY2       = 8;
    }
}
