using Foundation;
using ObjCRuntime;

namespace TensorFlowLiteTaskText
{
	// @interface TFLBertNLClassifierOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLBertNLClassifierOptions
	{
		// @property (nonatomic) int maxSeqLen;
		[Export ("maxSeqLen")]
		int MaxSeqLen { get; set; }
	}

	// @interface TFLBertNLClassifier : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLBertNLClassifier
	{
		// +(instancetype _Nonnull)bertNLClassifierWithModelPath:(NSString * _Nonnull)modelPath __attribute__((swift_name("bertNLClassifier(modelPath:)")));
		[Static]
		[Export ("bertNLClassifierWithModelPath:")]
		TFLBertNLClassifier BertNLClassifierWithModelPath (string modelPath);

		// +(instancetype _Nonnull)bertNLClassifierWithModelPath:(NSString * _Nonnull)modelPath options:(TFLBertNLClassifierOptions * _Nonnull)options __attribute__((swift_name("bertNLClassifier(modelPath:options:)")));
		[Static]
		[Export ("bertNLClassifierWithModelPath:options:")]
		TFLBertNLClassifier BertNLClassifierWithModelPath (string modelPath, TFLBertNLClassifierOptions options);

		// -(NSDictionary<NSString *,NSNumber *> * _Nonnull)classifyWithText:(NSString * _Nonnull)text __attribute__((swift_name("classify(text:)")));
		[Export ("classifyWithText:")]
		NSDictionary<NSString, NSNumber> ClassifyWithText (string text);
	}

	// @interface TFLQAAnswer : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLQAAnswer
	{
		// @property (nonatomic) struct TFLPos pos;
		[Export ("pos", ArgumentSemantic.Assign)]
		TFLPos Pos { get; set; }

		// @property (nonatomic) NSString * _Nonnull text;
		[Export ("text")]
		string Text { get; set; }
	}

	// @interface TFLBertQuestionAnswerer : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLBertQuestionAnswerer
	{
		// +(instancetype _Nonnull)questionAnswererWithModelPath:(NSString * _Nonnull)modelPath __attribute__((swift_name("questionAnswerer(modelPath:)")));
		[Static]
		[Export ("questionAnswererWithModelPath:")]
		TFLBertQuestionAnswerer QuestionAnswererWithModelPath (string modelPath);

		// -(NSArray<TFLQAAnswer *> * _Nonnull)answerWithContext:(NSString * _Nonnull)context question:(NSString * _Nonnull)question __attribute__((swift_name("answer(context:question:)")));
		[Export ("answerWithContext:question:")]
		TFLQAAnswer[] AnswerWithContext (string context, string question);
	}

	// @interface TFLNLClassifierOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLNLClassifierOptions
	{
		// @property (nonatomic) int inputTensorIndex;
		[Export ("inputTensorIndex")]
		int InputTensorIndex { get; set; }

		// @property (nonatomic) int outputScoreTensorIndex;
		[Export ("outputScoreTensorIndex")]
		int OutputScoreTensorIndex { get; set; }

		// @property (nonatomic) int outputLabelTensorIndex;
		[Export ("outputLabelTensorIndex")]
		int OutputLabelTensorIndex { get; set; }

		// @property (nonatomic) NSString * _Nonnull inputTensorName;
		[Export ("inputTensorName")]
		string InputTensorName { get; set; }

		// @property (nonatomic) NSString * _Nonnull outputScoreTensorName;
		[Export ("outputScoreTensorName")]
		string OutputScoreTensorName { get; set; }

		// @property (nonatomic) NSString * _Nonnull outputLabelTensorName;
		[Export ("outputLabelTensorName")]
		string OutputLabelTensorName { get; set; }
	}

	// @interface TFLNLClassifier : NSObject
	[BaseType (typeof(NSObject))]
	interface TFLNLClassifier
	{
		// +(instancetype _Nonnull)nlClassifierWithModelPath:(NSString * _Nonnull)modelPath options:(TFLNLClassifierOptions * _Nonnull)options __attribute__((swift_name("nlClassifier(modelPath:options:)")));
		[Static]
		[Export ("nlClassifierWithModelPath:options:")]
		TFLNLClassifier NlClassifierWithModelPath (string modelPath, TFLNLClassifierOptions options);

		// -(NSDictionary<NSString *,NSNumber *> * _Nonnull)classifyWithText:(NSString * _Nonnull)text __attribute__((swift_name("classify(text:)")));
		[Export ("classifyWithText:")]
		NSDictionary<NSString, NSNumber> ClassifyWithText (string text);
	}
}
