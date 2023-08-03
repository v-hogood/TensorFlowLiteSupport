using System;
using Foundation;
using ObjCRuntime;

namespace TensorFlowLite
{
	// @interface TFLDelegate : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLDelegate
	{
		// @property (readonly, nonatomic) TFLCDelegate _Nonnull cDelegate;
		[NullAllowed, Export ("cDelegate")]
		NSObject WeakCDelegate { get; }
	}

	// @interface TFLInterpreter : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLInterpreter
	{
		// @property (readonly, nonatomic) NSUInteger inputTensorCount;
		[Export ("inputTensorCount")]
		nuint InputTensorCount { get; }

		// @property (readonly, nonatomic) NSUInteger outputTensorCount;
		[Export ("outputTensorCount")]
		nuint OutputTensorCount { get; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull signatureKeys;
		[Export ("signatureKeys")]
		string[] SignatureKeys { get; }

		// -(instancetype _Nullable)initWithModelPath:(NSString * _Nonnull)modelPath error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithModelPath:error:")]
		NativeHandle Constructor (string modelPath, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithModelPath:(NSString * _Nonnull)modelPath options:(TFLInterpreterOptions * _Nonnull)options error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithModelPath:options:error:")]
		NativeHandle Constructor (string modelPath, TFLInterpreterOptions options, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithModelPath:(NSString * _Nonnull)modelPath options:(TFLInterpreterOptions * _Nonnull)options delegates:(NSArray<TFLDelegate *> * _Nonnull)delegates error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export ("initWithModelPath:options:delegates:error:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string modelPath, TFLInterpreterOptions options, TFLDelegate[] delegates, [NullAllowed] out NSError error);

		// -(BOOL)invokeWithError:(NSError * _Nullable * _Nullable)error;
		[Export ("invokeWithError:")]
		bool InvokeWithError ([NullAllowed] out NSError error);

		// -(TFLTensor * _Nullable)inputTensorAtIndex:(NSUInteger)index error:(NSError * _Nullable * _Nullable)error;
		[Export ("inputTensorAtIndex:error:")]
		[return: NullAllowed]
		TFLTensor InputTensorAtIndex (nuint index, [NullAllowed] out NSError error);

		// -(TFLTensor * _Nullable)outputTensorAtIndex:(NSUInteger)index error:(NSError * _Nullable * _Nullable)error;
		[Export ("outputTensorAtIndex:error:")]
		[return: NullAllowed]
		TFLTensor OutputTensorAtIndex (nuint index, [NullAllowed] out NSError error);

		// -(BOOL)resizeInputTensorAtIndex:(NSUInteger)index toShape:(NSArray<NSNumber *> * _Nonnull)shape error:(NSError * _Nullable * _Nullable)error;
		[Export ("resizeInputTensorAtIndex:toShape:error:")]
		bool ResizeInputTensorAtIndex (nuint index, NSNumber[] shape, [NullAllowed] out NSError error);

		// -(BOOL)allocateTensorsWithError:(NSError * _Nullable * _Nullable)error;
		[Export ("allocateTensorsWithError:")]
		bool AllocateTensorsWithError ([NullAllowed] out NSError error);

		// -(TFLSignatureRunner * _Nullable)signatureRunnerWithKey:(NSString * _Nonnull)key error:(NSError * _Nullable * _Nullable)error;
		[Export ("signatureRunnerWithKey:error:")]
		[return: NullAllowed]
		TFLSignatureRunner SignatureRunnerWithKey (string key, [NullAllowed] out NSError error);
	}

	// @interface TFLInterpreterOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLInterpreterOptions
	{
		// @property (nonatomic) NSUInteger numberOfThreads;
		[Export ("numberOfThreads")]
		nuint NumberOfThreads { get; set; }

		// @property (nonatomic) BOOL useXNNPACK;
		[Export ("useXNNPACK")]
		bool UseXNNPACK { get; set; }
	}

	// @interface TFLQuantizationParameters : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLQuantizationParameters
	{
		// @property (readonly, nonatomic) float scale;
		[Export ("scale")]
		float Scale { get; }

		// @property (readonly, nonatomic) int32_t zeroPoint;
		[Export ("zeroPoint")]
		int ZeroPoint { get; }
	}

	[Static]
	partial interface Constants
	{
		// extern const NSErrorDomain _Nonnull TFLSignatureRunnerErrorDomain;
		[Field ("TFLSignatureRunnerErrorDomain", "__Internal")]
		NSString TFLSignatureRunnerErrorDomain { get; }
	}

	// @interface TFLSignatureRunner : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLSignatureRunner
	{
		// @property (readonly, nonatomic) NSString * _Nonnull signatureKey;
		[Export ("signatureKey")]
		string SignatureKey { get; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull inputs;
		[Export ("inputs")]
		string[] Inputs { get; }

		// @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull outputs;
		[Export ("outputs")]
		string[] Outputs { get; }

		// -(TFLTensor * _Nullable)inputTensorWithName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
		[Export ("inputTensorWithName:error:")]
		[return: NullAllowed]
		TFLTensor InputTensorWithName (string name, [NullAllowed] out NSError error);

		// -(TFLTensor * _Nullable)outputTensorWithName:(NSString * _Nonnull)name error:(NSError * _Nullable * _Nullable)error;
		[Export ("outputTensorWithName:error:")]
		[return: NullAllowed]
		TFLTensor OutputTensorWithName (string name, [NullAllowed] out NSError error);

		// -(BOOL)resizeInputTensorWithName:(NSString * _Nonnull)name toShape:(NSArray<NSNumber *> * _Nonnull)shape error:(NSError * _Nullable * _Nullable)error;
		[Export ("resizeInputTensorWithName:toShape:error:")]
		bool ResizeInputTensorWithName (string name, NSNumber[] shape, [NullAllowed] out NSError error);

		// -(BOOL)allocateTensorsWithError:(NSError * _Nullable * _Nullable)error;
		[Export ("allocateTensorsWithError:")]
		bool AllocateTensorsWithError ([NullAllowed] out NSError error);

		// -(BOOL)invokeWithInputs:(NSDictionary<NSString *,NSData *> * _Nonnull)inputs Error:(NSError * _Nullable * _Nullable)error;
		[Export ("invokeWithInputs:Error:")]
		bool InvokeWithInputs (NSDictionary<NSString, NSData> inputs, [NullAllowed] out NSError error);
	}

	// @interface TFLTensor : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLTensor
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) TFLTensorDataType dataType;
		[Export ("dataType")]
		TFLTensorDataType DataType { get; }

		// @property (readonly, nonatomic) TFLQuantizationParameters * _Nullable quantizationParameters;
		[NullAllowed, Export ("quantizationParameters")]
		TFLQuantizationParameters QuantizationParameters { get; }

		// -(BOOL)copyData:(NSData * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
		[Export ("copyData:error:")]
		bool CopyData (NSData data, [NullAllowed] out NSError error);

		// -(NSData * _Nullable)dataWithError:(NSError * _Nullable * _Nullable)error;
		[Export ("dataWithError:")]
		[return: NullAllowed]
		NSData DataWithError ([NullAllowed] out NSError error);

		// -(NSArray<NSNumber *> * _Nullable)shapeWithError:(NSError * _Nullable * _Nullable)error;
		[Export ("shapeWithError:")]
		[return: NullAllowed]
		NSNumber[] ShapeWithError ([NullAllowed] out NSError error);
	}

	// [Static]
	partial interface Constants
	{
		// extern NSString *const _Nonnull TFLVersion;
		[Field ("TFLVersion", "__Internal")]
		NSString TFLVersion { get; }

		// extern double TFLTensorFlowLiteVersionNumber;
		[Field ("TFLTensorFlowLiteVersionNumber", "__Internal")]
		double TFLTensorFlowLiteVersionNumber { get; }

		// extern const unsigned char[] TFLTensorFlowLiteVersionString;
		[Field ("TFLTensorFlowLiteVersionString", "__Internal")]
		NSString TFLTensorFlowLiteVersionString { get; }
	}
}
