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