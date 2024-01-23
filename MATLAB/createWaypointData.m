% Create sample waypoint data for trajectory generation
%% Common parameters
% Rigid Body Tree information
%connectRobotStudio;
eeName = 'tool0';
load('IRB1200.mat');
numJoints = numel(gen3.homeConfiguration);
ikInitGuess = gen3.homeConfiguration;

% Maximum number of waypoints (for Simulink)
maxWaypoints = 20;

% Positions (X Y Z)
waypoints = pos';
         
% Euler Angles (Z Y X) relative to the home orientation       
orientations = [0     0    0;
                pi/8  0    0; 
                0    pi/2  0;
               -pi/8  0    0;
                0     0    0]';   
            
% Array of waypoint times
waypointTimes = 0:20:140;

% Trajectory sample time
ts = 0.2;
trajTimes = 0:ts:waypointTimes(end);


%% Additional parameters

% Boundary conditions (for polynomial trajectories)
% Velocity (cubic and quintic)
waypointVels = 0.1 *[ 0  1  0;
                     -1  0  0;
                      0 -1  0;
                      1  0  0;
                      0  1  0]';

% Acceleration (quintic only)
waypointAccels = zeros(size(waypointVels));

% Acceleration times (trapezoidal only)
waypointAccelTimes = diff(waypointTimes)/4;
