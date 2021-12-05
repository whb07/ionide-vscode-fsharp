module Tests

open System
open Xunit

open Ionide.VSCode.FSharp

[<Fact>]
let ``isNetCoreApp handles versioning`` () =
    let info:DTO.ProjectResponseInfoDotnetSdk = {
        IsTestProject=false
        Configuration=""
        IsPackable=true
        TargetFramework="net5.0"
        TargetFrameworkIdentifier=""
        TargetFrameworkVersion=""
        RestoreSuccess=true
        TargetFrameworks=[]
        RunCmd=None
        IsPublishable=None
    }
    // let project = {
    //     Project="/tmp/hello"
    //     Files=[||]
    //     Output="out"
    //     References=[||]
    //     ProjectReferences=[||]
    //     PackageReferences=[||]
    //     Logs=Map.empty
    //     OutputType=""
    //     Info=info
    //     Items=[||]
    //     AdditionalInfo=Map.empty
    // }
    Assert.True(info.RestoreSuccess)
