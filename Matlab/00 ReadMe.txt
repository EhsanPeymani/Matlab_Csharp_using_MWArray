Creared on: 2017-January
Created by: Ehsan Peymani

Objective: This Matlab class library acts as the busines layer for deployment of the MATLAB .NET assemblies.
This class library is to use the MATLAB .NET assembly (which is not type safe), and use the MWArray API.

MATLAB Component: The MATLAB .NET assemblies are generated using MATLAB Compiler SDK (compiler: Microsoft SDK 7.1)

Important: ==> Platform target must be set to x64.
Important: ==> You need MATLAB Runtime v90 (MATLAB 8.6 (2015b) and MATLAB Compiler SDK 6.1)
Important: ==> Make sure the reference to MWArray API is established correctly at your PC.

References: This class library requires to reference to the following files:
- MWArray API, after installing the run-time engine (2016b), found at C:\Program Files\MATLAB\MATLAB Runtime\v91\toolbox\dotnetbuilder\bin\win64\v2.0
- (user created) MatlabExpertedFunctions (containing 3 classes)


****************
MATLAB Functions
****************

-----------------------------------
Functions in MatlabSimpleFunctions
-----------------------------------

function z = add(x, y)
z = x + y;
end
% sum of two inputs of any compatible type


----------------------------
Functions in MatlabFunctions
----------------------------
function y = makesquare(x)
y = magic(x);
end
% input: scalar
% output: variable size matrix

===========================================================
function [y, determinant, eigenvalues] = makesquare_full(x)
y = magic(x);           % variable size matrix
determinant = det(y);   % scalar
eigenvalues = eig(y);   % variable size vector
end
% input: scalar
% output: a collection of variable size matrix, scalar, and variable size
% vector

===========================================
function y = makesquare_in_out_structure(x)

%% Finding values
M = magic(x.Dimension) * x.Multiplier;  % variable size matrix
determinant = det(M);                   % scalar
[eigenvectors, eigenvalues] = eig(M);   % variable size matrices

%% Defining the outoput structure 
field1 = 'Matrix';
field2 = 'Determinant';
field3 = 'Eigenvalues';
field4 = 'Eigenvectors';
field5 = 'Input_Details';

y = struct(field1, M, field2, determinant, field3, diag(eigenvalues), field4, eigenvectors, field5, x);
end
% input: structure
% output: structure

=====================================
function y = makesquare_in_vector(x)
x_sum = sum(x);
y = magic(x_sum);
end
% input: variable size vector
% output: variable size matrix

=====================================
function y = makesquare_structure(x)

%% Finding values
M = magic(x);                           % variable size matrix
determinant = det(M);                   % scalar
[eigenvectors, eigenvalues] = eig(M);   % variable size matrices

%% Defining the outoput structure 
field1 = 'Matrix';
field2 = 'Determinant';
field3 = 'Eigenvalues';
field4 = 'Eigenvectors';

y = struct(field1, M, field2, determinant, field3, diag(eigenvalues), field4, eigenvectors);
end
% input: scalar
% output: structure

Functions in MatlabPlottingFunctions
------------------------------------
function y = DisplayPlot(x,z, plotTitle, plotXLabel, plotYLabel, FigureName)
y = figure;
plot(x,z, '--*');
title(plotTitle);
ylabel(plotYLabel);
xlabel(plotXLabel);
y.Name = FigureName;
y.IntegerHandle = 'off'; 
end
% Plot a 2D graph for 2 input vector x and z

===============================================
function output = PlotMesh(FigureName, Title)
% Plots MATLAB mesh in 3D plot

%% Creating data
[X,Y] = meshgrid(-8:.5:8);
R = sqrt(X.^2 + Y.^2) + eps;
Z = sin(R)./R;

%% Opening figure and plotting
h = figure;
mesh(Z);

%% Turning off the figure name number and setting the desired name
h.Name = FigureName;
h.IntegerHandle = 'off';
title(Title);

output = 1;

