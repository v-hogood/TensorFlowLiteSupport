using ObjCRuntime;

namespace TensorFlowLite
{
	[Native]
	public enum TFLInterpreterErrorCode : ulong
	{
		InvalidTensorIndex,
		InvalidInputByteSize,
		InvalidShape,
		FailedToLoadModel,
		FailedToCreateInterpreter,
		FailedToInvoke,
		FailedToGetTensor,
		InvalidTensor,
		FailedToResizeInputTensor,
		FailedToCopyDataToInputTensor,
		CopyDataToOutputTensorNotAllowed,
		FailedToGetDataFromTensor,
		FailedToAllocateTensors,
		AllocateTensorsRequired,
		InvokeInterpreterRequired
	}

	[Native]
	public enum TFLSignatureRunnerErrorCode : ulong
	{
		InvalidInputByteSize,
		InvalidShape,
		FailedToCreateSignatureRunner,
		FailedToInvoke,
		FailedToGetTensor,
		InvalidTensor,
		FailedToResizeInputTensor,
		FailedToCopyDataToInputTensor,
		CopyDataToOutputTensorNotAllowed,
		FailedToGetDataFromTensor,
		FailedToAllocateTensors
	}

	[Native]
	public enum TFLTensorDataType : ulong
	{
		NoType,
		Float32,
		Float16,
		Int32,
		UInt8,
		Int64,
		Bool,
		Int16,
		Int8,
		Float64
	}
}
