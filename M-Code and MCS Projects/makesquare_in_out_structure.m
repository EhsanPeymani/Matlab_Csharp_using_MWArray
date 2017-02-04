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
field5 = 'InputDetails';

y = struct(field1, M, field2, determinant, field3, diag(eigenvalues), field4, eigenvectors, field5, x);
end
% input: structure
% output: structure