using ObjCRuntime;

namespace TensorFlowLiteTaskVision
{
	[Native]
	public enum CoreMLDelegateEnabledDevices : ulong
	{
		All = 0,
		WithNeuralEngine = 1
	}

	[Native]
	public enum TFLSupportErrorCode : ulong
	{
		SupportErrorCodeUnspecifiedError = 1,
		SupportErrorCodeInvalidArgumentError = 2,
		SupportErrorCodeInvalidFlatBufferError = 3,
		SupportErrorCodeUnsupportedBuiltinOpError = 4,
		SupportErrorCodeUnsupportedCustomOpError = 5,
		SupportErrorCodeFileNotFoundError = 100,
		SupportErrorCodeFilePermissionDeniedError,
		SupportErrorCodeFileReadError,
		SupportErrorCodeFileMmapError,
		SupportErrorCodeMetadataInvalidSchemaVersionError = 200,
		SupportErrorCodeMetadataAssociatedFileNotFoundError,
		SupportErrorCodeMetadataAssociatedFileZipError,
		SupportErrorCodeMetadataInconsistencyError,
		SupportErrorCodeMetadataInvalidProcessUnitsError,
		SupportErrorCodeMetadataNumLabelsMismatchError,
		SupportErrorCodeMetadataMalformedScoreCalibrationError,
		SupportErrorCodeMetadataInvalidNumSubgraphsError,
		SupportErrorCodeMetadataMissingNormalizationOptionsError,
		SupportErrorCodeMetadataInvalidContentPropertiesError,
		SupportErrorCodeMetadataNotFoundError,
		SupportErrorCodeMetadataMissingLabelsError,
		SupportErrorCodeMetadataInvalidTokenizerError,
		SupportErrorCodeInvalidNumInputTensorsError = 300,
		SupportErrorCodeInvalidInputTensorDimensionsError,
		SupportErrorCodeInvalidInputTensorTypeError,
		SupportErrorCodeInvalidInputTensorSizeError,
		SupportErrorCodeInputTensorNotFoundError,
		SupportErrorCodeInvalidOutputTensorDimensionsError = 400,
		SupportErrorCodeInvalidOutputTensorTypeError,
		SupportErrorCodeOutputTensorNotFoundError,
		SupportErrorCodeInvalidNumOutputTensorsError,
		SupportErrorCodeImageProcessingError = 500,
		SupportErrorCodeImageProcessingInvalidArgumentError,
		SupportErrorCodeImageProcessingBackendError,
		ErrorCodeFirst = SupportErrorCodeUnspecifiedError,
		ErrorCodeLast = SupportErrorCodeImageProcessingBackendError,
		SupportErrorCodeNotFoundError = 900,
		SupportErrorCodeInternalError
	}

	[Native]
	public enum TFLOutputType : ulong
	{
		Unspecified,
		CategoryMask,
		ConfidenceMasks
	}
}
