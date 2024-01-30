# TensorFlow Lite with Select TensorFlow ops

For enabling the Select TensorFlow ops for your TensorFlow Lite app, please add
the `TensorFlowLiteSelectTfOps` package to your project file, in addition to the
`TensorFlowLite` package.

```
<ItemGroup>
  <PackageReference Include="TensorFlowLite.iOS" Version="2.14.0" />
  <PackageReference Include="TensorFlowLiteSelectTfOps.iOS" Version="2.14.0" />
</ItemGroup>
```

Please refer to the [Select operators from TensorFlow][ops-select] guide for
more details.

[ops-select]: https://www.tensorflow.org/lite/guide/ops_select#ios
