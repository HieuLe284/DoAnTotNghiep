%%Setup
clear;
clc;
close all;

%%function Connect
tc=tcpip('192.168.125.1',55000,"Timeout",10);   % Robot
%tc=tcpip('127.0.0.1',55000);        % Simu
fopen(tc);
posABB=fread (tc);
%%Convert to matrix
posChar=char(posABB)';
cutSTR=strsplit(posChar,'@');
pos_m=zeros(length(cutSTR)-1,3);
for i=1:length(cutSTR)-1
    pos_m(i,:)=str2num(cutSTR{i});
end
pos=pos_m/1000;