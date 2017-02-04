function y = makesquare_in_vector(x)
x_sum = sum(x);
y = magic(x_sum);
end
% input: variable size vector
% output: variable size matrix