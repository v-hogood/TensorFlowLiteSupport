# TensorFlow Lite for iOS

[TensorFlow Lite](https://www.tensorflow.org/lite/) is TensorFlow's lightweight
solution for mobile developers. It enables low-latency inference of on-device
machine learning models with a small binary size and fast performance supporting
hardware acceleration.

### .NET developers

Add the TensorFlow Lite package to your project file:

```
<ItemGroup>
  <PackageReference Include="TensorFlowLite.iOS" Version="2.14.0" />
</ItemGroup>
```

In your C# files, import the module:

```
using TensorFlowLite;
```

