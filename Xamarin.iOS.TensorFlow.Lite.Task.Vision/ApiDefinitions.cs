using System;
using CoreGraphics;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;
using TensorFlowLiteTaskVision;
using UIKit;

namespace TensorFlowLiteTaskVision
{
	// @interface GMLImage : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface GMLImage
	{
		// @property (readonly, nonatomic) CGFloat width;
		[Export ("width")]
		nfloat Width { get; }

		// @property (readonly, nonatomic) CGFloat height;
		[Export ("height")]
		nfloat Height { get; }

		// @property (nonatomic) UIImageOrientation orientation;
		[Export ("orientation", ArgumentSemantic.Assign)]
		UIImageOrientation Orientation { get; set; }

		// @property (readonly, nonatomic) GMLImageSourceType imageSourceType;
		[Export ("imageSourceType")]
		nint ImageSourceType { get; }

		// @property (readonly, nonatomic) UIImage * _Nullable image;
		[NullAllowed, Export ("image")]
		UIImage Image { get; }

		// @property (readonly, nonatomic) CVPixelBufferRef _Nullable pixelBuffer;
		[NullAllowed, Export ("pixelBuffer")]
		CVPixelBuffer PixelBuffer { get; }

		// @property (readonly, nonatomic) CMSampleBufferRef _Nullable sampleBuffer;
		[NullAllowed, Export ("sampleBuffer")]
		CMSampleBuffer SampleBuffer { get; }

		// -(instancetype _Nullable)initWithImage:(UIImage * _Nonnull)image __attribute__((objc_designated_initializer));
		[Export ("initWithImage:")]
		[DesignatedInitializer]
		IntPtr Constructor (UIImage image);

		// -(instancetype _Nullable)initWithPixelBuffer:(CVPixelBufferRef _Nonnull)pixelBuffer __attribute__((objc_designated_initializer));
		[Export ("initWithPixelBuffer:")]
		[DesignatedInitializer]
		IntPtr Constructor (CVPixelBuffer pixelBuffer);

		// -(instancetype _Nullable)initWithSampleBuffer:(CMSampleBufferRef _Nonnull)sampleBuffer __attribute__((objc_designated_initializer));
		[Export ("initWithSampleBuffer:")]
		[DesignatedInitializer]
		IntPtr Constructor (CMSampleBuffer sampleBuffer);
	}

	// @interface TFLCpuSettings : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface TFLCpuSettings : INSCopying
	{
		// @property (nonatomic) int numThreads;
		[Export ("numThreads")]
		int NumThreads { get; set; }
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

	// @interface TFLDetection : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLDetection
	{
		// @property (readonly, nonatomic) CGRect boundingBox;
		[Export ("boundingBox")]
		CGRect BoundingBox { get; }

		// @property (readonly, nonatomic) NSArray<TFLCategory *> * _Nonnull categories;
		[Export ("categories")]
		TFLCategory[] Categories { get; }

		// -(instancetype _Nonnull)initWithBoundingBox:(CGRect)boundingBox categories:(NSArray<TFLCategory *> * _Nonnull)categories;
		[Export ("initWithBoundingBox:categories:")]
		IntPtr Constructor (CGRect boundingBox, TFLCategory[] categories);
	}

	// @interface TFLDetectionResult : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLDetectionResult
	{
		// @property (readonly, nonatomic) NSArray<TFLDetection *> * _Nonnull detections;
		[Export ("detections")]
		TFLDetection[] Detections { get; }

		// -(instancetype _Nonnull)initWithDetections:(NSArray<TFLDetection *> * _Nonnull)detections;
		[Export ("initWithDetections:")]
		IntPtr Constructor (TFLDetection[] detections);
	}

	// @interface TFLImageClassifierOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLImageClassifierOptions
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

	// @interface TFLImageClassifier : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLImageClassifier
	{
		// +(instancetype _Nullable)imageClassifierWithOptions:(TFLImageClassifierOptions * _Nonnull)options error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("classifier(options:)")));
		[Static]
		[Export ("imageClassifierWithOptions:error:")]
		[return: NullAllowed]
		TFLImageClassifier ImageClassifierWithOptions (TFLImageClassifierOptions options, [NullAllowed] out NSError error);

		// -(TFLClassificationResult * _Nullable)classifyWithGMLImage:(GMLImage * _Nonnull)image error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("classify(mlImage:)")));
		[Export ("classifyWithGMLImage:error:")]
		[return: NullAllowed]
		TFLClassificationResult ClassifyWithGMLImage (GMLImage image, [NullAllowed] out NSError error);

		// -(TFLClassificationResult * _Nullable)classifyWithGMLImage:(GMLImage * _Nonnull)image regionOfInterest:(CGRect)roi error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("classify(mlImage:regionOfInterest:)")));
		[Export ("classifyWithGMLImage:regionOfInterest:error:")]
		[return: NullAllowed]
		TFLClassificationResult ClassifyWithGMLImage (GMLImage image, CGRect roi, [NullAllowed] out NSError error);
	}

	// @interface TFLConfidenceMask : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLConfidenceMask
	{
		// @property (readonly, nonatomic) float * _Nonnull mask;
		[Export ("mask")]
		IntPtr Mask { get; }

		// @property (readonly, nonatomic) NSInteger width;
		[Export ("width")]
		nint Width { get; }

		// @property (readonly, nonatomic) NSInteger height;
		[Export ("height")]
		nint Height { get; }

		// -(instancetype _Nonnull)initWithWidth:(NSInteger)width height:(NSInteger)height mask:(float * _Nullable)mask;
		[Export ("initWithWidth:height:mask:")]
		IntPtr Constructor (nint width, nint height, [NullAllowed] IntPtr mask);
	}

	// @interface TFLCategoryMask : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLCategoryMask
	{
		// @property (readonly, nonatomic) UInt8 * _Nonnull mask;
		[Export ("mask")]
		IntPtr Mask { get; }

		// @property (readonly, nonatomic) NSInteger width;
		[Export ("width")]
		nint Width { get; }

		// @property (readonly, nonatomic) NSInteger height;
		[Export ("height")]
		nint Height { get; }

		// -(instancetype _Nonnull)initWithWidth:(NSInteger)width height:(NSInteger)height mask:(UInt8 * _Nullable)mask;
		[Export ("initWithWidth:height:mask:")]
		IntPtr Constructor (nint width, nint height, [NullAllowed] IntPtr mask);
	}

	// @interface TFLColoredLabel : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLColoredLabel
	{
		// @property (readonly, nonatomic) NSUInteger r;
		[Export ("r")]
		nuint R { get; }

		// @property (readonly, nonatomic) NSUInteger g;
		[Export ("g")]
		nuint G { get; }

		// @property (readonly, nonatomic) NSUInteger b;
		[Export ("b")]
		nuint B { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull label;
		[Export ("label")]
		string Label { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull displayName;
		[Export ("displayName")]
		string DisplayName { get; }

		// -(instancetype _Nonnull)initWithRed:(NSUInteger)r green:(NSUInteger)g blue:(NSUInteger)b label:(NSString * _Nonnull)label displayName:(NSString * _Nonnull)displayName;
		[Export ("initWithRed:green:blue:label:displayName:")]
		IntPtr Constructor (nuint r, nuint g, nuint b, string label, string displayName);
	}

	// @interface TFLSegmentation : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLSegmentation
	{
		// @property (readonly, nonatomic) NSArray<TFLConfidenceMask *> * _Nullable confidenceMasks;
		[NullAllowed, Export ("confidenceMasks")]
		TFLConfidenceMask[] ConfidenceMasks { get; }

		// @property (readonly, nonatomic) TFLCategoryMask * _Nullable categoryMask;
		[NullAllowed, Export ("categoryMask")]
		TFLCategoryMask CategoryMask { get; }

		// @property (readonly, nonatomic) NSArray<TFLColoredLabel *> * _Nonnull coloredLabels;
		[Export ("coloredLabels")]
		TFLColoredLabel[] ColoredLabels { get; }

		// -(instancetype _Nonnull)initWithConfidenceMasks:(NSArray<TFLConfidenceMask *> * _Nonnull)confidenceMasks coloredLabels:(NSArray<TFLColoredLabel *> * _Nonnull)coloredLabels;
		[Export ("initWithConfidenceMasks:coloredLabels:")]
		IntPtr Constructor (TFLConfidenceMask[] confidenceMasks, TFLColoredLabel[] coloredLabels);

		// -(instancetype _Nonnull)initWithCategoryMask:(TFLCategoryMask * _Nonnull)categoryMask coloredLabels:(NSArray<TFLColoredLabel *> * _Nonnull)coloredLabels;
		[Export ("initWithCategoryMask:coloredLabels:")]
		IntPtr Constructor (TFLCategoryMask categoryMask, TFLColoredLabel[] coloredLabels);
	}

	// @interface TFLSegmentationResult : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLSegmentationResult
	{
		// @property (readonly, nonatomic) NSArray<TFLSegmentation *> * _Nonnull segmentations;
		[Export ("segmentations")]
		TFLSegmentation[] Segmentations { get; }

		// -(instancetype _Nonnull)initWithSegmentations:(NSArray<TFLSegmentation *> * _Nonnull)segmentations;
		[Export ("initWithSegmentations:")]
		IntPtr Constructor (TFLSegmentation[] segmentations);
	}

	// @interface TFLImageSegmenterOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLImageSegmenterOptions
	{
		// @property (copy, nonatomic) TFLBaseOptions * _Nonnull baseOptions;
		[Export ("baseOptions", ArgumentSemantic.Copy)]
		TFLBaseOptions BaseOptions { get; set; }

		// @property (nonatomic) TFLOutputType outputType;
		[Export ("outputType", ArgumentSemantic.Assign)]
		TFLOutputType OutputType { get; set; }

		// @property (copy, nonatomic) NSString * _Nonnull displayNamesLocale;
		[Export ("displayNamesLocale")]
		string DisplayNamesLocale { get; set; }

		// -(instancetype _Nonnull)initWithModelPath:(NSString * _Nonnull)modelPath;
		[Export ("initWithModelPath:")]
		IntPtr Constructor (string modelPath);
	}

	// @interface TFLImageSegmenter : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLImageSegmenter
	{
		// +(instancetype _Nullable)imageSegmenterWithOptions:(TFLImageSegmenterOptions * _Nonnull)options error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("segmenter(options:)")));
		[Static]
		[Export ("imageSegmenterWithOptions:error:")]
		[return: NullAllowed]
		TFLImageSegmenter ImageSegmenterWithOptions (TFLImageSegmenterOptions options, [NullAllowed] out NSError error);

		// -(TFLSegmentationResult * _Nullable)segmentWithGMLImage:(GMLImage * _Nonnull)image error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("segment(mlImage:)")));
		[Export ("segmentWithGMLImage:error:")]
		[return: NullAllowed]
		TFLSegmentationResult SegmentWithGMLImage (GMLImage image, [NullAllowed] out NSError error);
	}

	// @interface TFLObjectDetectorOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLObjectDetectorOptions
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

	// @interface TFLObjectDetector : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TFLObjectDetector
	{
		// +(instancetype _Nullable)objectDetectorWithOptions:(TFLObjectDetectorOptions * _Nonnull)options error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("detector(options:)")));
		[Static]
		[Export ("objectDetectorWithOptions:error:")]
		[return: NullAllowed]
		TFLObjectDetector ObjectDetectorWithOptions (TFLObjectDetectorOptions options, [NullAllowed] out NSError error);

		// -(TFLDetectionResult * _Nullable)detectWithGMLImage:(GMLImage * _Nonnull)image error:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("detect(mlImage:)")));
		[Export ("detectWithGMLImage:error:")]
		[return: NullAllowed]
		TFLDetectionResult DetectWithGMLImage (GMLImage image, [NullAllowed] out NSError error);
	}
}
