using System;
using Foundation;
using ObjCRuntime;
using TensorFlowLiteTaskAudio;

namespace TensorFlowLiteTaskAudio
{
	// @interface TFLAudioFormat : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLAudioFormat
	{
		// @property (readonly, nonatomic) NSUInteger channelCount;
		[Export ("channelCount")]
		nuint ChannelCount { get; }

		// @property (readonly, nonatomic) NSUInteger sampleRate;
		[Export ("sampleRate")]
		nuint SampleRate { get; }

		// -(instancetype _Nonnull)initWithChannelCount:(NSUInteger)channelCount sampleRate:(NSUInteger)sampleRate;
		[Export ("initWithChannelCount:sampleRate:")]
		IntPtr Constructor (nuint channelCount, nuint sampleRate);

		// -(instancetype _Nonnull)initWithSampleRate:(NSUInteger)sampleRate;
		[Export ("initWithSampleRate:")]
		IntPtr Constructor (nuint sampleRate);
	}

	// @interface TFLFloatBuffer : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface TFLFloatBuffer : INSCopying
	{
		// @property (readonly, nonatomic) NSUInteger size;
		[Export ("size")]
		nuint Size { get; }

		// @property (readonly, nonatomic) float * _Nonnull data;
		[Export ("data")]
		IntPtr Data { get; }

		// -(instancetype _Nonnull)initWithData:(float * _Nonnull)data size:(NSUInteger)size;
		[Export ("initWithData:size:")]
		IntPtr Constructor (IntPtr data, nuint size);

		// -(instancetype _Nonnull)initWithSize:(NSUInteger)size;
		[Export ("initWithSize:")]
		IntPtr Constructor (nuint size);

		// -(void)clear;
		[Export ("clear")]
		void Clear ();
	}

	// @interface TFLAudioRecord : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLAudioRecord
	{
		// @property (readonly, nonatomic) TFLAudioFormat * _Nonnull audioFormat;
		[Export ("audioFormat")]
		TFLAudioFormat AudioFormat { get; }

		// @property (readonly, nonatomic) NSUInteger bufferSize;
		[Export ("bufferSize")]
		nuint BufferSize { get; }

		// -(instancetype _Nullable)initWithAudioFormat:(TFLAudioFormat * _Nonnull)format bufferSize:(NSUInteger)bufferSize error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithAudioFormat:bufferSize:error:")]
		IntPtr Constructor (TFLAudioFormat format, nuint bufferSize, [NullAllowed] out NSError error);

		// -(BOOL)startRecordingWithError:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("startRecording()")));
		[Export ("startRecordingWithError:")]
		bool StartRecordingWithError ([NullAllowed] out NSError error);

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(TFLFloatBuffer * _Nullable)readAtOffset:(NSUInteger)offset withSize:(NSUInteger)size error:(NSError * _Nullable * _Nullable)error;
		[Export ("readAtOffset:withSize:error:")]
		[return: NullAllowed]
		TFLFloatBuffer ReadAtOffset (nuint offset, nuint size, [NullAllowed] out NSError error);
	}

	// @interface TFLAudioTensor : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLAudioTensor
	{
		// @property (readonly, nonatomic) TFLAudioFormat * _Nonnull audioFormat;
		[Export ("audioFormat")]
		TFLAudioFormat AudioFormat { get; }

		// @property (readonly, nonatomic) TFLFloatBuffer * _Nonnull buffer;
		[Export ("buffer")]
		TFLFloatBuffer Buffer { get; }

		// @property (readonly, nonatomic) NSUInteger bufferSize;
		[Export ("bufferSize")]
		nuint BufferSize { get; }

		// -(instancetype _Nonnull)initWithAudioFormat:(TFLAudioFormat * _Nonnull)format sampleCount:(NSUInteger)sampleCount __attribute__((objc_designated_initializer));
		[Export ("initWithAudioFormat:sampleCount:")]
		[DesignatedInitializer]
		IntPtr Constructor (TFLAudioFormat format, nuint sampleCount);

		// -(BOOL)loadAudioRecord:(TFLAudioRecord * _Nonnull)audioRecord withError:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("load(audioRecord:)")));
		[Export ("loadAudioRecord:withError:")]
		bool LoadAudioRecord (TFLAudioRecord audioRecord, [NullAllowed] out NSError error);

		// -(BOOL)loadBuffer:(TFLFloatBuffer * _Nonnull)buffer offset:(NSUInteger)offset size:(NSUInteger)size error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("load(buffer:offset:size:)")));
		[Export ("loadBuffer:offset:size:error:")]
		bool LoadBuffer (TFLFloatBuffer buffer, nuint offset, nuint size, [NullAllowed] out NSError error);
	}

	// @interface TFLCoreMLDelegateSettings : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface TFLCoreMLDelegateSettings : INSCopying
	{
		// -(instancetype _Nonnull)initWithCoreMLVersion:(int32_t)coreMLVersion enableddevices:(CoreMLDelegateEnabledDevices)enabledDevices;
		[Export ("initWithCoreMLVersion:enableddevices:")]
		IntPtr Constructor (int coreMLVersion, CoreMLDelegateEnabledDevices enabledDevices);

		// @property (readonly, nonatomic) CoreMLDelegateEnabledDevices enabledDevices;
		[Export ("enabledDevices")]
		CoreMLDelegateEnabledDevices EnabledDevices { get; }

		// @property (readonly, nonatomic) int32_t coreMLVersion;
		[Export ("coreMLVersion")]
		int CoreMLVersion { get; }
	}

	// @interface TFLCpuSettings : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface TFLCpuSettings : INSCopying
	{
		// @property (nonatomic) NSInteger numThreads;
		[Export ("numThreads")]
		nint NumThreads { get; set; }
	}

	// @interface TFLComputeSettings : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface TFLComputeSettings : INSCopying
	{
		// @property (copy, nonatomic) TFLCpuSettings * _Nonnull cpuSettings;
		[Export ("cpuSettings", ArgumentSemantic.Copy)]
		TFLCpuSettings CpuSettings { get; set; }
	}

	// @interface TFLExternalFile : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface TFLExternalFile : INSCopying
	{
		// @property (copy, nonatomic) NSString * _Nonnull filePath;
		[Export ("filePath")]
		string FilePath { get; set; }
	}

	// @interface TFLBaseOptions : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface TFLBaseOptions : INSCopying
	{
		// @property (copy, nonatomic) TFLExternalFile * _Nonnull modelFile;
		[Export ("modelFile", ArgumentSemantic.Copy)]
		TFLExternalFile ModelFile { get; set; }

		// @property (copy, nonatomic) TFLComputeSettings * _Nonnull computeSettings;
		[Export ("computeSettings", ArgumentSemantic.Copy)]
		TFLComputeSettings ComputeSettings { get; set; }

		// @property (copy, nonatomic) TFLCoreMLDelegateSettings * _Nullable coreMLDelegateSettings;
		[NullAllowed, Export ("coreMLDelegateSettings", ArgumentSemantic.Copy)]
		TFLCoreMLDelegateSettings CoreMLDelegateSettings { get; set; }
	}

	// @interface TFLClassificationOptions : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface TFLClassificationOptions : INSCopying
	{
		// @property (copy, nonatomic) NSArray * _Nonnull labelDenyList;
		[Export ("labelDenyList", ArgumentSemantic.Copy)]
		NSString[] LabelDenyList { get; set; }

		// @property (copy, nonatomic) NSArray * _Nonnull labelAllowList;
		[Export ("labelAllowList", ArgumentSemantic.Copy)]
		NSString[] LabelAllowList { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull displayNamesLocale;
		[Export ("displayNamesLocale")]
		string DisplayNamesLocale { get; set; }

		// @property (nonatomic) float scoreThreshold;
		[Export ("scoreThreshold")]
		float ScoreThreshold { get; set; }

		// @property (nonatomic) NSInteger maxResults;
		[Export ("maxResults")]
		nint MaxResults { get; set; }
	}

	// @interface TFLCategory : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLCategory
	{
		// @property (readonly, nonatomic) NSInteger index;
		[Export ("index")]
		nint Index { get; }

		// @property (readonly, nonatomic) float score;
		[Export ("score")]
		float Score { get; }

		// @property (readonly, nonatomic) NSString * _Nullable label;
		[NullAllowed, Export ("label")]
		string Label { get; }

		// @property (readonly, nonatomic) NSString * _Nullable displayName;
		[NullAllowed, Export ("displayName")]
		string DisplayName { get; }

		// -(instancetype _Nonnull)initWithIndex:(NSInteger)index score:(float)score label:(NSString * _Nullable)label displayName:(NSString * _Nullable)displayName;
		[Export ("initWithIndex:score:label:displayName:")]
		IntPtr Constructor (nint index, float score, [NullAllowed] string label, [NullAllowed] string displayName);
	}

	// @interface TFLClassifications : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLClassifications
	{
		// @property (readonly, nonatomic) NSInteger headIndex;
		[Export ("headIndex")]
		nint HeadIndex { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull headName;
		[Export ("headName")]
		string HeadName { get; }

		// @property (readonly, nonatomic) NSArray<TFLCategory *> * _Nonnull categories;
		[Export ("categories")]
		TFLCategory[] Categories { get; }

		// -(instancetype _Nonnull)initWithHeadIndex:(NSInteger)headIndex categories:(NSArray<TFLCategory *> * _Nonnull)categories;
		[Export ("initWithHeadIndex:categories:")]
		IntPtr Constructor (nint headIndex, TFLCategory[] categories);

		// -(instancetype _Nonnull)initWithHeadIndex:(NSInteger)headIndex headName:(NSString * _Nullable)headName categories:(NSArray<TFLCategory *> * _Nonnull)categories;
		[Export ("initWithHeadIndex:headName:categories:")]
		IntPtr Constructor (nint headIndex, [NullAllowed] string headName, TFLCategory[] categories);
	}

	// @interface TFLClassificationResult : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLClassificationResult
	{
		// @property (readonly, nonatomic) NSArray<TFLClassifications *> * _Nonnull classifications;
		[Export ("classifications")]
		TFLClassifications[] Classifications { get; }

		// -(instancetype _Nonnull)initWithClassifications:(NSArray<TFLClassifications *> * _Nonnull)classifications;
		[Export ("initWithClassifications:")]
		IntPtr Constructor (TFLClassifications[] classifications);
	}

	// @interface TFLAudioClassifierOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLAudioClassifierOptions
	{
		// @property (copy, nonatomic) TFLBaseOptions * _Nonnull baseOptions;
		[Export ("baseOptions", ArgumentSemantic.Copy)]
		TFLBaseOptions BaseOptions { get; set; }

		// @property (copy, nonatomic) TFLClassificationOptions * _Nonnull classificationOptions;
		[Export ("classificationOptions", ArgumentSemantic.Copy)]
		TFLClassificationOptions ClassificationOptions { get; set; }

		// -(instancetype _Nonnull)initWithModelPath:(NSString * _Nonnull)modelPath;
		[Export ("initWithModelPath:")]
		IntPtr Constructor (string modelPath);
	}

	// @interface TFLAudioClassifier : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLAudioClassifier
	{
		// +(instancetype _Nullable)audioClassifierWithOptions:(TFLAudioClassifierOptions * _Nonnull)options error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("classifier(options:)")));
		[Static]
		[Export ("audioClassifierWithOptions:error:")]
		[return: NullAllowed]
		TFLAudioClassifier AudioClassifierWithOptions (TFLAudioClassifierOptions options, [NullAllowed] out NSError error);

		// -(TFLAudioTensor * _Nonnull)createInputAudioTensor;
		[Export ("createInputAudioTensor")]
		TFLAudioTensor CreateInputAudioTensor ();

		// -(TFLAudioRecord * _Nullable)createAudioRecordWithError:(NSError * _Nullable * _Nullable)error;
		[Export ("createAudioRecordWithError:")]
		[return: NullAllowed]
		TFLAudioRecord CreateAudioRecordWithError ([NullAllowed] out NSError error);

		// -(TFLClassificationResult * _Nullable)classifyWithAudioTensor:(TFLAudioTensor * _Nonnull)audioTensor error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("classify(audioTensor:)")));
		[Export ("classifyWithAudioTensor:error:")]
		[return: NullAllowed]
		TFLClassificationResult ClassifyWithAudioTensor (TFLAudioTensor audioTensor, [NullAllowed] out NSError error);
	}
}
