using System;
using Foundation;

namespace TensorFlowLite
{
	// @interface TFLDelegate : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLDelegate
	{
		[Wrap ("WeakCDelegate")]
		unsafe void* CDelegate { get; }

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

		// -(instancetype _Nullable)initWithModelPath:(NSString * _Nonnull)modelPath error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithModelPath:error:")]
		IntPtr Constructor (string modelPath, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithModelPath:(NSString * _Nonnull)modelPath options:(TFLInterpreterOptions * _Nonnull)options error:(NSError * _Nullable * _Nullable)error;
		[Export ("initWithModelPath:options:error:")]
		IntPtr Constructor (string modelPath, TFLInterpreterOptions options, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithModelPath:(NSString * _Nonnull)modelPath options:(TFLInterpreterOptions * _Nonnull)options delegates:(NSArray<TFLDelegate *> * _Nonnull)delegates error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export ("initWithModelPath:options:delegates:error:")]
		[DesignatedInitializer]
		IntPtr Constructor (string modelPath, TFLInterpreterOptions options, TFLDelegate[] delegates, [NullAllowed] out NSError error);

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

	[Static]
	partial interface Constants
	{
		// extern NSString *const _Nonnull TFLVersion;
		[Field ("TFLVersion", "__Internal")]
		NSString TFLVersion { get; }
	}
}
