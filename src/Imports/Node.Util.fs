module Ionide.VSCode.FSharp.Node.Util

open System
open Fable.Core

type IExports =
    abstract member format: format: string * [<ParamArray>] args: obj [] -> string

[<Import("*", "util")>]
let Util: IExports = jsNative


type ObjectExports =
    abstract member keys: o: obj -> ResizeArray<string>

module Object =
    [<Emit("Object.keys($0)")>]
    let keys (o) : ResizeArray<string> = jsNative
