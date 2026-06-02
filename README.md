# Computer Vision Ar assignment
# AR Body Tracking Demo

## Overview
<img width="1919" height="968" alt="image" src="https://github.com/user-attachments/assets/a2186b64-4ca7-4b84-b9e1-150ba69062a0" />

This project is a real-time upper body tracking application developed in Unity using MediaPipe Pose Landmark Detection.

The application captures webcam input, detects key upper body joints, and visualizes them using marker objects in real time. The system tracks the user's:

* Head
* Left Shoulder
* Right Shoulder
* Left Elbow
* Right Elbow
* Left Wrist
* Right Wrist

The project was developed as part of a Unity Game Developer technical assessment.

---

## Features
<img width="1919" height="980" alt="image" src="https://github.com/user-attachments/assets/04620119-eb01-4ff3-babe-aa73e3d8f093" />

* Real-time webcam feed integration
* MediaPipe Pose Landmark Detection
* Upper body joint tracking
* Visual markers rendered on tracked joints
* Real-time landmark updates
* Desktop application support
* Maintains smooth performance above 20 FPS

---

## Technologies Used

* Unity 6 LTS
* C#
* MediaPipe Unity Plugin
* Unity UI System
* WebcamTexture API

---

## Tracked Landmarks

| Landmark       | Description            |
| -------------- | ---------------------- |
| Head           | Head position tracking |
| Left Shoulder  | Left shoulder joint    |
| Right Shoulder | Right shoulder joint   |
| Left Elbow     | Left elbow joint       |
| Right Elbow    | Right elbow joint      |
| Left Wrist     | Left wrist joint       |
| Right Wrist    | Right wrist joint      |

---

## Project Architecture

```text
Webcam Input
      ↓
MediaPipe Pose Detection
      ↓
Landmark Processing
      ↓
Joint Visualization
      ↓
User Interface
```

### Components

#### Webcam Manager

Responsible for:

* Webcam initialization
* Camera feed capture
* Frame delivery

#### Pose Tracking Manager

Responsible for:

* Running MediaPipe pose detection
* Extracting landmark positions
* Updating tracking data

#### Joint Visualizer

Responsible for:

* Creating marker objects
* Updating marker positions
* Rendering tracked joints

#### UI System

Responsible for:

* Webcam display
* Status information
* FPS display

---

## Installation

### Requirements

* Unity 2022.3+ (Developed using Unity 6 LTS)
* Windows Desktop
* Webcam

### Running the Project

1. Clone the repository:

```bash
git clone https://github.com/YourUsername/YourRepository.git
```

2. Open the project in Unity.

3. Open the main scene.

4. Press Play.

5. Allow webcam access if prompted.

---

## Build Instructions

1. Open Unity.
2. Navigate to:

```text
File → Build Settings
```

3. Select Windows Platform.
4. Click Build.

---

## Performance

The application is optimized for desktop use and maintains real-time pose tracking performance while rendering upper body landmarks.

Target Performance:

* 20+ FPS minimum
* Real-time landmark updates
* Smooth webcam rendering

---

## Future Improvements

* Full body tracking
* Hand gesture recognition
* Pose-based interactions
* AR mini-games
* Multiplayer body tracking applications

---

## Author

Rohit Walunj

Unity Gameplay Developer | C# Programmer | Game Systems & Interactive Experiences
