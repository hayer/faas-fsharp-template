# F# Template for [OpenFaaS-cli](https://github.com/openfaas/faas-cli) 

## Usage

```shell
faas-cli template pull https://github.com/hayer/faas-fsharp-template
faas-cli new myfunction --lang fsharp
```

You will find the newly created directory ```myfunction```:
 * Function.fsproj : project definition
 * FunctionHandler.fs : entry point
   * ```type RequestParameters``` example of type for deserializing input parameters

#### Feel like something is missing? Open an issue!
