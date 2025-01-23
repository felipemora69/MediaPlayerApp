# MediaPlayerApp

The MultiMedia Player Application is a versatile multimedia player built using Windows Forms, designed to play audio and video files and allow users to manipulate images. This application supports the playback of different media formats, including MP3, WAV, and MP4 files. It also allows users to modify images by applying different filters (Black and White, Sepia) and rotate them interactively. The project utilizes multiple libraries, including NAudio.Wave for audio playback and WMPLib for video playback.

Features
Audio Playback: Supports both WAV and MP3 audio formats. Users can open audio files and play them using the integrated audio player.
Video Playback: Allows users to play video files (e.g., MP4) using Windows Media Player.
Image Manipulation: Users can load an image, rotate it, and apply different filters like "Black and White" and "Sepia" to enhance the image.
Multi-Audio Support: Using NAudio, users can play multiple audio files simultaneously (e.g., combining sound samples) with different outputs.

Key Features and Controls
Audio Controls
Play WAV Audio: Opens a file dialog to select and play a WAV audio file.
Play MP3 Audio: Opens a file dialog to select and play an MP3 audio file using Windows Media Player.
Play Sample (Multiple Audio): Plays two sample audio files simultaneously using NAudio.Wave.
Stop Audio/Video: Stops the playback of any media (audio or video).
Video Controls
Play Video: Opens a file dialog to select and play an MP4 video file using Windows Media Player.
Image Controls
Open Image: Allows users to load an image from their system.
Rotate Image: Rotates the loaded image by 90 degrees (flip).
Modify Image: Apply visual effects to the image (Black and White, Sepia).

