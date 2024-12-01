# educationalApp - Desktop Application for Children's Education

## Overview
educationalApp is a WPF-based desktop application developed in C# to teach children the basics of the Cyrillic alphabet and numbers. The application consists of two main windows displaying images of letters and digits. When users click on any letter or digit, the corresponding pronunciation is played.

---

## Project Structure
**Folders**
- **audio**: Contains audio files (in .wav format) for the pronunciation of letters in the Cyrillic alphabet.
- **digits**: Contains images (in .jpg format) representing digits.
- **digitsAudio**: Contains audio files (in .wav format) for the pronunciation of digits.
- **letters**: Contains images (in .jpg format) representing the Cyrillic letters.

**Files**
- **MainWindow.xaml.cs:** The main file of the application containing the logic for the interaction with the window, including events for mouse clicks, hovering, window resizing, and audio playback.


---

## Key Features
- **Interactive Learning**: The application allows children to click on images of Cyrillic letters and digits, which will play the corresponding pronunciation through sound.

- **Dynamic Content Visibility**: The application uses buttons to toggle between displaying the letters or digits, allowing children to interact with both sets of content seamlessly.

- **Window Controls**: The app provides basic window controls (resize, close, and minimize) with interactive visual effects on the header and buttons.


---

## Main Components
MainWindow.xaml.cs: This is the primary file for the functionality of the main window. It includes event handlers for the mouse interaction with the image elements (letters and digits), window dragging, resizing, and closing, as well as playing sounds when letters or digits are clicked.


---

## Notable Methods
- **Image_MouseDown:** Plays the sound corresponding to the clicked letter or digit.
- **symbol_MouseEnter & symbol_MouseLeave:** Changes the opacity of the image elements when the mouse hovers over them to provide visual feedback.
- **DigitsDown & LettersDown:** Switch between displaying the Cyrillic letters or the digits.
- **Window_Closing:** Prevents the window from closing by default (you can modify this if needed).


---

## Instructions
- **Run the Application:** Launch the MainWindow.xaml.cs file in a WPF environment.
- **Interact with Letters and Digits:** Click on any letter or digit to hear its pronunciation.
- **Switch Between Letters and Digits:** Use the buttons to toggle between showing the letters or digits.
- **Window Controls:** The app has draggable windows, and you can resize, minimize, or close it using the appropriate buttons.


---

## Contributors
Developed by Escapist_1871
