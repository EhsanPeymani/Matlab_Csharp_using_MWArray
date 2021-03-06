# Matlab_Csharp_using_MWArray
This C# project presents a test project to show how MATLAB .NET libraries generated by MATLAB Compiler SDK can be used in C#.

The marshaling data between .NET and MATLAB is carried out by MWArray API. This requires a bit of programming to manually convert .NET data types to MATLAB data types and vice versa. For more automatic data marshalling, use type safe mode, explored https://github.com/EhsanPeymani/Matlab_Csharp_using_TypeSafeMode.

MATLAB M-Code and MATLAB Compiler SDK projects are in M-Code and MCS Projects	folder.

The generated MATLAB .NET Assembly is found in Matlab .NET Libraries folder.

IMPORTANT >>> Read the readme file in Matlab folder, for details of implementation and requirements.

IMPORTANT >>> Remember to handle exceptions (try-catch) when you pass objects between MATLAB and .NET.

The solution has two projects:

1. Presentation project which is a WinForm project. This project refers to the second project in the solution, but has no reference to MATLAB data conversion API (MWArray) or the generated .NET assemblies. All data types are .NET native types.

2. Matlab Class library, which creates an abstraction layer for MATLAB API and MATLAB .NET libraries.


To be able to run the application, you need to have MATALAB Runtime v9.0 (64bit) installed. Get it for free from https://se.mathworks.com/supportfiles/downloads/R2015b/deployment_files/R2015b/installers/win64/MCR_R2015b_win64_installer.exe

