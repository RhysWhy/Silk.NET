// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    public enum CLEnum
    {
        Success = 0x0,
        DeviceNotFound = unchecked((int)0xFFFFFFFFFFFFFFFF),
        DeviceNotAvailable = unchecked((int)0xFFFFFFFFFFFFFFFE),
        CompilerNotAvailable = unchecked((int)0xFFFFFFFFFFFFFFFD),
        MemObjectAllocationFailure = unchecked((int)0xFFFFFFFFFFFFFFFC),
        OutOfResources = unchecked((int)0xFFFFFFFFFFFFFFFB),
        OutOfHostMemory = unchecked((int)0xFFFFFFFFFFFFFFFA),
        ProfilingInfoNotAvailable = unchecked((int)0xFFFFFFFFFFFFFFF9),
        MemCopyOverlap = unchecked((int)0xFFFFFFFFFFFFFFF8),
        ImageFormatMismatch = unchecked((int)0xFFFFFFFFFFFFFFF7),
        ImageFormatNotSupported = unchecked((int)0xFFFFFFFFFFFFFFF6),
        BuildProgramFailure = unchecked((int)0xFFFFFFFFFFFFFFF5),
        MapFailure = unchecked((int)0xFFFFFFFFFFFFFFF4),
        InvalidValue = unchecked((int)0xFFFFFFFFFFFFFFE2),
        InvalidDeviceType = unchecked((int)0xFFFFFFFFFFFFFFE1),
        InvalidPlatform = unchecked((int)0xFFFFFFFFFFFFFFE0),
        InvalidDevice = unchecked((int)0xFFFFFFFFFFFFFFDF),
        InvalidContext = unchecked((int)0xFFFFFFFFFFFFFFDE),
        InvalidQueueProperties = unchecked((int)0xFFFFFFFFFFFFFFDD),
        InvalidCommandQueue = unchecked((int)0xFFFFFFFFFFFFFFDC),
        InvalidHostPtr = unchecked((int)0xFFFFFFFFFFFFFFDB),
        InvalidMemObject = unchecked((int)0xFFFFFFFFFFFFFFDA),
        InvalidImageFormatDescriptor = unchecked((int)0xFFFFFFFFFFFFFFD9),
        InvalidImageSize = unchecked((int)0xFFFFFFFFFFFFFFD8),
        InvalidSampler = unchecked((int)0xFFFFFFFFFFFFFFD7),
        InvalidBinary = unchecked((int)0xFFFFFFFFFFFFFFD6),
        InvalidBuildOptions = unchecked((int)0xFFFFFFFFFFFFFFD5),
        InvalidProgram = unchecked((int)0xFFFFFFFFFFFFFFD4),
        InvalidProgramExecutable = unchecked((int)0xFFFFFFFFFFFFFFD3),
        InvalidKernelName = unchecked((int)0xFFFFFFFFFFFFFFD2),
        InvalidKernelDefinition = unchecked((int)0xFFFFFFFFFFFFFFD1),
        InvalidKernel = unchecked((int)0xFFFFFFFFFFFFFFD0),
        InvalidArgIndex = unchecked((int)0xFFFFFFFFFFFFFFCF),
        InvalidArgValue = unchecked((int)0xFFFFFFFFFFFFFFCE),
        InvalidArgSize = unchecked((int)0xFFFFFFFFFFFFFFCD),
        InvalidKernelArgs = unchecked((int)0xFFFFFFFFFFFFFFCC),
        InvalidWorkDimension = unchecked((int)0xFFFFFFFFFFFFFFCB),
        InvalidWorkGroupSize = unchecked((int)0xFFFFFFFFFFFFFFCA),
        InvalidWorkItemSize = unchecked((int)0xFFFFFFFFFFFFFFC9),
        InvalidGlobalOffset = unchecked((int)0xFFFFFFFFFFFFFFC8),
        InvalidEventWaitList = unchecked((int)0xFFFFFFFFFFFFFFC7),
        InvalidEvent = unchecked((int)0xFFFFFFFFFFFFFFC6),
        InvalidOperation = unchecked((int)0xFFFFFFFFFFFFFFC5),
        InvalidGLObject = unchecked((int)0xFFFFFFFFFFFFFFC4),
        InvalidBufferSize = unchecked((int)0xFFFFFFFFFFFFFFC3),
        InvalidMipLevel = unchecked((int)0xFFFFFFFFFFFFFFC2),
        InvalidGlobalWorkSize = unchecked((int)0xFFFFFFFFFFFFFFC1),
        False = 0x0,
        True = 0x1,
        PlatformProfile = 0x900,
        PlatformVersion = 0x901,
        PlatformName = 0x902,
        PlatformVendor = 0x903,
        PlatformExtensions = 0x904,
        DeviceTypeDefault = 0x1,
        DeviceTypeCpu = 0x2,
        DeviceTypeGpu = 0x4,
        DeviceTypeAccelerator = 0x8,
        DeviceTypeAll = unchecked((int)0xFFFFFFFF),
        DeviceType = 0x1000,
        DeviceVendorID = 0x1001,
        DeviceMaxComputeUnits = 0x1002,
        DeviceMaxWorkItemDimensions = 0x1003,
        DeviceMaxWorkGroupSize = 0x1004,
        DeviceMaxWorkItemSizes = 0x1005,
        DevicePreferredVectorWidthChar = 0x1006,
        DevicePreferredVectorWidthShort = 0x1007,
        DevicePreferredVectorWidthInt = 0x1008,
        DevicePreferredVectorWidthLong = 0x1009,
        DevicePreferredVectorWidthFloat = 0x100A,
        DevicePreferredVectorWidthDouble = 0x100B,
        DeviceMaxClockFrequency = 0x100C,
        DeviceAddressBits = 0x100D,
        DeviceMaxReadImageArgs = 0x100E,
        DeviceMaxWriteImageArgs = 0x100F,
        DeviceMaxMemAllocSize = 0x1010,
        DeviceImage2DMaxWidth = 0x1011,
        DeviceImage2DMaxHeight = 0x1012,
        DeviceImage3DMaxWidth = 0x1013,
        DeviceImage3DMaxHeight = 0x1014,
        DeviceImage3DMaxDepth = 0x1015,
        DeviceImageSupport = 0x1016,
        DeviceMaxParameterSize = 0x1017,
        DeviceMaxSamplers = 0x1018,
        DeviceMemBaseAddrAlign = 0x1019,
        DeviceSingleFPConfig = 0x101B,
        DeviceGlobalMemCacheType = 0x101C,
        DeviceGlobalMemCachelineSize = 0x101D,
        DeviceGlobalMemCacheSize = 0x101E,
        DeviceGlobalMemSize = 0x101F,
        DeviceMaxConstantBufferSize = 0x1020,
        DeviceMaxConstantArgs = 0x1021,
        DeviceLocalMemType = 0x1022,
        DeviceLocalMemSize = 0x1023,
        DeviceErrorCorrectionSupport = 0x1024,
        DeviceProfilingTimerResolution = 0x1025,
        DeviceEndianLittle = 0x1026,
        DeviceAvailable = 0x1027,
        DeviceCompilerAvailable = 0x1028,
        DeviceExecutionCapabilities = 0x1029,
        DeviceName = 0x102B,
        DeviceVendor = 0x102C,
        DriverVersion = 0x102D,
        DeviceProfile = 0x102E,
        DeviceVersion = 0x102F,
        DeviceExtensions = 0x1030,
        DevicePlatform = 0x1031,
        FPDenorm = 0x1,
        FPInfNan = 0x2,
        FPRoundToNearest = 0x4,
        FPRoundToZero = 0x8,
        FPRoundToInf = 0x16,
        FPFma = 0x32,
        None = 0x0,
        ReadOnlyCache = 0x1,
        ReadWriteCache = 0x2,
        Local = 0x1,
        Global = 0x2,
        ExecKernel = 0x1,
        ExecNativeKernel = 0x2,
        QueueOutOfOrderExecModeEnable = 0x1,
        QueueProfilingEnable = 0x2,
        ContextReferenceCount = 0x1080,
        ContextDevices = 0x1081,
        ContextProperties = 0x1082,
        ContextPlatform = 0x1084,
        QueueContext = 0x1090,
        QueueDevice = 0x1091,
        QueueReferenceCount = 0x1092,
        QueueProperties = 0x1093,
        MemReadWrite = 0x1,
        MemWriteOnly = 0x2,
        MemReadOnly = 0x4,
        MemUseHostPtr = 0x8,
        MemAllocHostPtr = 0x16,
        MemCopyHostPtr = 0x32,
        ProfilingCommandQueued = 0x1280,
        ProfilingCommandSubmit = 0x1281,
        ProfilingCommandStart = 0x1282,
        ProfilingCommandEnd = 0x1283,
        R = 0x10B0,
        A = 0x10B1,
        RG = 0x10B2,
        RA = 0x10B3,
        Rgb = 0x10B4,
        Rgba = 0x10B5,
        Bgra = 0x10B6,
        Argb = 0x10B7,
        Intensity = 0x10B8,
        Luminance = 0x10B9,
        SNormInt8 = 0x10D0,
        SNormInt16 = 0x10D1,
        UnormInt8 = 0x10D2,
        UnormInt16 = 0x10D3,
        UnormShort565 = 0x10D4,
        UnormShort555 = 0x10D5,
        UnormInt101010 = 0x10D6,
        SignedInt8 = 0x10D7,
        SignedInt16 = 0x10D8,
        SignedInt32 = 0x10D9,
        UnsignedInt8 = 0x10DA,
        UnsignedInt16 = 0x10DB,
        UnsignedInt32 = 0x10DC,
        HalfFloat = 0x10DD,
        Float = 0x10DE,
        MemObjectBuffer = 0x10F0,
        MemObjectImage2D = 0x10F1,
        MemObjectImage3D = 0x10F2,
        MemType = 0x1100,
        MemFlags = 0x1101,
        MemSize = 0x1102,
        MemHostPtr = 0x1103,
        MemMapCount = 0x1104,
        MemReferenceCount = 0x1105,
        MemContext = 0x1106,
        ImageFormat = 0x1110,
        ImageElementSize = 0x1111,
        ImageRowPitch = 0x1112,
        ImageSlicePitch = 0x1113,
        ImageWidth = 0x1114,
        ImageHeight = 0x1115,
        ImageDepth = 0x1116,
        AddressNone = 0x1130,
        AddressClampToEdge = 0x1131,
        AddressClamp = 0x1132,
        AddressRepeat = 0x1133,
        FilterNearest = 0x1140,
        FilterLinear = 0x1141,
        SamplerReferenceCount = 0x1150,
        SamplerContext = 0x1151,
        SamplerNormalizedCoords = 0x1152,
        SamplerAddressingMode = 0x1153,
        SamplerFilterMode = 0x1154,
        MapRead = 0x1,
        MapWrite = 0x2,
        ProgramReferenceCount = 0x1160,
        ProgramContext = 0x1161,
        ProgramNumDevices = 0x1162,
        ProgramDevices = 0x1163,
        ProgramSource = 0x1164,
        ProgramBinarySizes = 0x1165,
        ProgramBinaries = 0x1166,
        ProgramBuildStatus = 0x1181,
        ProgramBuildOptions = 0x1182,
        ProgramBuildLog = 0x1183,
        BuildSuccess = 0x0,
        BuildNone = unchecked((int)0xFFFFFFFFFFFFFFFF),
        BuildError = unchecked((int)0xFFFFFFFFFFFFFFFE),
        BuildInProgress = unchecked((int)0xFFFFFFFFFFFFFFFD),
        KernelFunctionName = 0x1190,
        KernelNumArgs = 0x1191,
        KernelReferenceCount = 0x1192,
        KernelContext = 0x1193,
        KernelProgram = 0x1194,
        KernelWorkGroupSize = 0x11B0,
        KernelCompileWorkGroupSize = 0x11B1,
        KernelLocalMemSize = 0x11B2,
        KernelPreferredWorkGroupSizeMultiple = 0x11B3,
        KernelPrivateMemSize = 0x11B4,
        EventCommandQueue = 0x11D0,
        EventCommandType = 0x11D1,
        EventReferenceCount = 0x11D2,
        EventCommandExecutionStatus = 0x11D3,
        CommandNdrangeKernel = 0x11F0,
        CommandTask = 0x11F1,
        CommandNativeKernel = 0x11F2,
        CommandReadBuffer = 0x11F3,
        CommandWriteBuffer = 0x11F4,
        CommandCopyBuffer = 0x11F5,
        CommandReadImage = 0x11F6,
        CommandWriteImage = 0x11F7,
        CommandCopyImage = 0x11F8,
        CommandCopyImageToBuffer = 0x11F9,
        CommandCopyBufferToImage = 0x11FA,
        CommandMapBuffer = 0x11FB,
        CommandMapImage = 0x11FC,
        CommandUnmapMemObject = 0x11FD,
        CommandMarker = 0x11FE,
        CommandAcquireGLObjects = 0x11FF,
        CommandReleaseGLObjects = 0x1200,
        Complete = 0x0,
        Running = 0x1,
        Submitted = 0x2,
        Queued = 0x3,
        DeviceMinDataTypeAlignSize = 0x101A,
        DeviceQueueProperties = 0x102A,
        MisalignedSubBufferOffset = unchecked((int)0xFFFFFFFFFFFFFFF3),
        ExecStatusErrorForEventsInWaitList = unchecked((int)0xFFFFFFFFFFFFFFF2),
        InvalidProperty = unchecked((int)0xFFFFFFFFFFFFFFC0),
        DevicePreferredVectorWidthHalf = 0x1034,
        DeviceNativeVectorWidthChar = 0x1036,
        DeviceNativeVectorWidthShort = 0x1037,
        DeviceNativeVectorWidthInt = 0x1038,
        DeviceNativeVectorWidthLong = 0x1039,
        DeviceNativeVectorWidthFloat = 0x103A,
        DeviceNativeVectorWidthDouble = 0x103B,
        DeviceNativeVectorWidthHalf = 0x103C,
        DeviceOpenclCVersion = 0x103D,
        FPSoftFloat = 0x64,
        ContextNumDevices = 0x1083,
        Rx = 0x10BA,
        RGx = 0x10BB,
        Rgbx = 0x10BC,
        MemAssociatedMemobject = 0x1107,
        MemOffset = 0x1108,
        AddressMirroredRepeat = 0x1134,
        EventContext = 0x11D4,
        CommandReadBufferRect = 0x1201,
        CommandWriteBufferRect = 0x1202,
        CommandCopyBufferRect = 0x1203,
        CommandUser = 0x1204,
        BufferCreateTypeRegion = 0x1220,
        DeviceHostUnifiedMemory = 0x1035,
        CompileProgramFailure = unchecked((int)0xFFFFFFFFFFFFFFF1),
        LinkerNotAvailable = unchecked((int)0xFFFFFFFFFFFFFFF0),
        LinkProgramFailure = unchecked((int)0xFFFFFFFFFFFFFFEF),
        DevicePartitionFailed = unchecked((int)0xFFFFFFFFFFFFFFEE),
        KernelArgInfoNotAvailable = unchecked((int)0xFFFFFFFFFFFFFFED),
        InvalidImageDescriptor = unchecked((int)0xFFFFFFFFFFFFFFBF),
        InvalidCompilerOptions = unchecked((int)0xFFFFFFFFFFFFFFBE),
        InvalidLinkerOptions = unchecked((int)0xFFFFFFFFFFFFFFBD),
        InvalidDevicePartitionCount = unchecked((int)0xFFFFFFFFFFFFFFBC),
        CommandBarrier = 0x1205,
        CommandMigrateMemObjects = 0x1206,
        CommandFillBuffer = 0x1207,
        CommandFillImage = 0x1208,
        Blocking = 1,
        NonBlocking = 0,
        DeviceTypeCustom = 0x16,
        DeviceDoubleFPConfig = 0x1032,
        DeviceLinkerAvailable = 0x103E,
        DeviceBuiltInKernels = 0x103F,
        DeviceImageMaxBufferSize = 0x1040,
        DeviceImageMaxArraySize = 0x1041,
        DeviceParentDevice = 0x1042,
        DevicePartitionMaxSubDevices = 0x1043,
        DevicePartitionProperties = 0x1044,
        DevicePartitionAffinityDomain = 0x1045,
        DevicePartitionType = 0x1046,
        DeviceReferenceCount = 0x1047,
        DevicePreferredInteropUserSync = 0x1048,
        DevicePrintfBufferSize = 0x1049,
        FPCorrectlyRoundedDivideSqrt = 0x128,
        ContextInteropUserSync = 0x1085,
        DevicePartitionEqually = 0x1086,
        DevicePartitionByCounts = 0x1087,
        DevicePartitionByAffinityDomain = 0x1088,
        DeviceAffinityDomainNuma = 0x1,
        DeviceAffinityDomainL4Cache = 0x2,
        DeviceAffinityDomainL3Cache = 0x4,
        DeviceAffinityDomainL2Cache = 0x8,
        DeviceAffinityDomainL1Cache = 0x16,
        DeviceAffinityDomainNextPartitionable = 0x32,
        MemHostWriteOnly = 0x128,
        MemHostReadOnly = 0x256,
        MemHostNoAccess = 0x512,
        MigrateMemObjectHost = 0x1,
        MigrateMemObjectContentUndefined = 0x2,
        Depth = 0x10BD,
        DepthStencil = 0x10BE,
        UnormInt24 = 0x10DF,
        MemObjectImage2DArray = 0x10F3,
        MemObjectImage1D = 0x10F4,
        MemObjectImage1DArray = 0x10F5,
        MemObjectImage1DBuffer = 0x10F6,
        ImageArraySize = 0x1117,
        ImageNumMipLevels = 0x1119,
        ImageNumSamples = 0x111A,
        MapWriteInvalidateRegion = 0x4,
        ProgramNumKernels = 0x1167,
        ProgramKernelNames = 0x1168,
        ProgramBinaryType = 0x1184,
        ProgramBinaryTypeNone = 0x0,
        ProgramBinaryTypeCompiledObject = 0x1,
        ProgramBinaryTypeLibrary = 0x2,
        ProgramBinaryTypeExecutable = 0x4,
        KernelAttributes = 0x1195,
        KernelArgAddressQualifier = 0x1196,
        KernelArgAccessQualifier = 0x1197,
        KernelArgTypeName = 0x1198,
        KernelArgTypeQualifier = 0x1199,
        KernelArgName = 0x119A,
        KernelArgAddressGlobal = 0x119B,
        KernelArgAddressLocal = 0x119C,
        KernelArgAddressConstant = 0x119D,
        KernelArgAddressPrivate = 0x119E,
        KernelArgAccessReadOnly = 0x11A0,
        KernelArgAccessWriteOnly = 0x11A1,
        KernelArgAccessReadWrite = 0x11A2,
        KernelArgAccessNone = 0x11A3,
        KernelArgTypeNone = 0x0,
        KernelArgTypeConst = 0x1,
        KernelArgTypeRestrict = 0x2,
        KernelArgTypeVolatile = 0x4,
        KernelGlobalWorkSize = 0x11B5,
        ImageBuffer = 0x1118,
        InvalidPipeSize = unchecked((int)0xFFFFFFFFFFFFFFBB),
        InvalidDeviceQueue = unchecked((int)0xFFFFFFFFFFFFFFBA),
        DeviceQueueOnHostProperties = 0x102A,
        DeviceImagePitchAlignment = 0x104A,
        DeviceImageBaseAddressAlignment = 0x104B,
        DeviceMaxReadWriteImageArgs = 0x104C,
        DeviceMaxGlobalVariableSize = 0x104D,
        DeviceQueueOnDeviceProperties = 0x104E,
        DeviceQueueOnDevicePreferredSize = 0x104F,
        DeviceQueueOnDeviceMaxSize = 0x1050,
        DeviceMaxOnDeviceQueues = 0x1051,
        DeviceMaxOnDeviceEvents = 0x1052,
        DeviceSvmCapabilities = 0x1053,
        DeviceGlobalVariablePreferredTotalSize = 0x1054,
        DeviceMaxPipeArgs = 0x1055,
        DevicePipeMaxActiveReservations = 0x1056,
        DevicePipeMaxPacketSize = 0x1057,
        DevicePreferredPlatformAtomicAlignment = 0x1058,
        DevicePreferredGlobalAtomicAlignment = 0x1059,
        DevicePreferredLocalAtomicAlignment = 0x105A,
        QueueOnDevice = 0x4,
        QueueOnDeviceDefault = 0x8,
        DeviceSvmCoarseGrainBuffer = 0x1,
        DeviceSvmFineGrainBuffer = 0x2,
        DeviceSvmFineGrainSystem = 0x4,
        DeviceSvmAtomics = 0x8,
        QueueSize = 0x1094,
        MemSvmFineGrainBuffer = 0x1024,
        MemSvmAtomics = 0x2048,
        MemKernelReadAndWrite = 0x4096,
        SRgb = 0x10BF,
        SRgbx = 0x10C0,
        SRgba = 0x10C1,
        SBgra = 0x10C2,
        Abgr = 0x10C3,
        MemObjectPipe = 0x10F7,
        MemUsesSvmPointer = 0x1109,
        PipePacketSize = 0x1120,
        PipeMaxPackets = 0x1121,
        SamplerMipFilterMode = 0x1155,
        SamplerLodMin = 0x1156,
        SamplerLodMax = 0x1157,
        ProgramBuildGlobalVariableTotalSize = 0x1185,
        KernelArgTypePipe = 0x8,
        KernelExecInfoSvmPtrs = 0x11B6,
        KernelExecInfoSvmFineGrainSystem = 0x11B7,
        CommandSvmFree = 0x1209,
        CommandSvmMemcpy = 0x120A,
        CommandSvmMemfill = 0x120B,
        CommandSvmMap = 0x120C,
        CommandSvmUnmap = 0x120D,
        ProfilingCommandComplete = 0x1284,
        PlatformHostTimerResolution = 0x905,
        DeviceILVersion = 0x105B,
        DeviceMaxNumSubGroups = 0x105C,
        DeviceSubGroupIndependentForwardProgress = 0x105D,
        QueueDeviceDefault = 0x1095,
        UnormInt1010102 = 0x10E0,
        ProgramIL = 0x1169,
        KernelMaxNumSubGroups = 0x11B9,
        KernelCompileNumSubGroups = 0x11BA,
        KernelMaxSubGroupSizeForNdrange = 0x2033,
        KernelSubGroupCountForNdrange = 0x2034,
        KernelLocalSizeForSubGroupCount = 0x11B8,
        InvalidSpecID = unchecked((int)0xFFFFFFFFFFFFFFB9),
        MaxSizeRestrictionExceeded = unchecked((int)0xFFFFFFFFFFFFFFB8),
        ProgramScopeGlobalCtorsPresent = 0x116A,
        ProgramScopeGlobalDtorsPresent = 0x116B,
    }
}
