function [y, determinant, eigenvalues] = makesquare_full(x)
y = magic(x);           % variable size matrix
determinant = det(y);   % scalar
eigenvalues = eig(y);   % variable size vector
end
% input: scalar
% output: a collection of variable size matrix, scalar, and variable size
% vector