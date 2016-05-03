namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Ouroboros")>]
[<assembly: AssemblyProductAttribute("Ouroboros")>]
[<assembly: AssemblyDescriptionAttribute("distributed EvoLisa with Akka.net")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
    let [<Literal>] InformationalVersion = "1.0"
