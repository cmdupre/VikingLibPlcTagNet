### This library was split out from Viking Logix Utility so that it could be used in other projects.

### To include in a project
* Add *[USER]\source\nuget_local* to nuget package sources
* Search/browse to include this package in the project

### When an update needs to be made to this library
* Update *<AssemblyVersion>* in project file
* Ensure *<GeneratePackageOnBuild>True</Gen..>* is set
* Package will be output to *[USER]\source\repos\VikingLibPlcTagNet\VikingLibPlcTagNet\bin\Release*
* Move this package to the local nuget directory specified above
* Import/update as necessary

### If version number issues arise, clear local nuget cache
* dotnet nuget locals all --clear
