using ObjCRuntime;

namespace TensorFlowLiteTaskVision
{
	[Native]
	public enum TFLSupportErrorCode : ulong
	{
		UnspecifiedError = 1,
		InvalidArgumentError = 2,
		InvalidFlatBufferError = 3,
		UnsupportedBuiltinOpError = 4,
		UnsupportedCustomOpError = 5,
		FileNotFoundError = 100,
		FilePermissionDeniedError,
		FileReadError,
		FileMmapError,
		MetadataInvalidSchemaVersionError = 200,
		MetadataAssociatedFileNotFoundError,
		MetadataAssociatedFileZipError,
		MetadataInconsistencyError,
		MetadataInvalidProcessUnitsError,
		MetadataNumLabelsMismatchError,
		MetadataMalformedScoreCalibrationError,
		MetadataInvalidNumSubgraphsError,
		MetadataMissingNormalizationOptionsError,
		MetadataInvalidContentPropertiesError,
		MetadataNotFoundError,
		MetadataMissingLabelsError,
		MetadataInvalidTokenizerError,
		InvalidNumInputTensorsError = 300,
		InvalidInputTensorDimensionsError,
		InvalidInputTensorTypeError,
		InvalidInputTensorSizeError,
		InputTensorNotFoundError,
		InvalidOutputTensorDimensionsError = 400,
		InvalidOutputTensorTypeError,
		OutputTensorNotFoundError,
		InvalidNumOutputTensorsError,
		ImageProcessingError = 500,
		ImageProcessingInvalidArgumentError,
		ImageProcessingBackendError,
		NotFoundError = 900,
		InternalError
	}

	[Native]
	public enum TFLOutputType : ulong
	{
		Unspecified,
		CategoryMask,
		ConfidenceMasks
	}
}
