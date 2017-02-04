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