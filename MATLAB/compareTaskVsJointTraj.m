% Compares joint space vs. task space trajectories

%% Setup
%clc
createWaypointData;
figure, hold on
plot3(waypoints(1,:),waypoints(2,:),waypoints(3,:),'-o','Color','b','MarkerSize',10,'MarkerFaceColor','#D9FFFF');
title('Trajectory Waypoints'); 
xlabel('X [m]');
ylabel('Y [m]');
zlabel('Z [m]');
grid on
view([45 45]);
% Define IK solver
ik = inverseKinematics('RigidBodyTree',gen3);
ikWeights = [1 1 1 1 1 1];
% Use a small sample time for this example, so the difference between joint
% and task space is clear due to evaluation of IK in task space trajectory.
ts = 0.2;
trajTimes = 0:ts:waypointTimes(end);
% Initialize matrices for plots
qTask = zeros(numJoints,numel(trajTimes)); % Derived joint angles in task space trajectory
posJoint = zeros(3,numel(trajTimes)); % Derived end effector positions in joint space trajectory

%% Create and evaluate a task space trajectory
ikInitGuess = jointAnglesHome';
ikInitGuess(ikInitGuess > pi) = ikInitGuess(ikInitGuess > pi) - 2*pi;
ikInitGuess(ikInitGuess < -pi) = ikInitGuess(ikInitGuess < -pi) + 2*pi;

disp('Running task space trajectory generation and evaluation...')
tic;

% Trajectory generation
[posTask,velTask,accelTask] = trapveltraj(waypoints,numel(trajTimes));
% Trajectory evaluation
for idx = 1:numel(trajTimes) 
    % Solve IK
    tgtPose = trvec2tform(posTask(:,idx)');
    [config,info] = ik(eeName,tgtPose,ikWeights,ikInitGuess);
    ikInitGuess = config;
    qTask(:,idx) = config;
end
numWaypoints = size(waypoints,2);
taskTime = toc;
disp(['Task space trajectory time : ' num2str(taskTime) ' s']);

%% Create comparison plots
% Compare trajectories in Cartesian space
close all
figure, hold on
plot3(posTask(1,:),posTask(2,:),posTask(3,:),'b-');
plot3(waypoints(1,:),waypoints(2,:),waypoints(3,:),'ko','LineWidth',2);
title('Trajectory Comparison'); 
xlabel('X [m]');
ylabel('Y [m]');
zlabel('Z [m]');
legend('Task Space Trajectory','Waypoints');
grid on
view([45 45]);

% Compare joint angles
% Plot each joint trajectory
for idx = 1:numJoints
    subplot(3,2,idx);
    plot(trajTimes,qTask(idx,:),'b-');
    for wIdx = 1:numWaypoints
       xline(waypointTimes(wIdx),'k--'); 
    end
    title(['Joint ' num2str(idx) ' Trajectory']); 
    xlabel('Time [s]');
    ylabel('Joint Angle [rad]');
    legend('Task Space Trajectory');
end
