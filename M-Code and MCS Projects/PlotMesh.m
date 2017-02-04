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

