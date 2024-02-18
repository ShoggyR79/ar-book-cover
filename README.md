# ar-book-cover

# Link to demo
https://youtu.be/xIh7yyMQoNc

# Images
The images are created by first capturing the book on the phone and sending it to the computer in ```./cover_images.pdf``` and then using vuforia database import created as target and downloaded to the computer (that file is ```./phd.unitypackage```)

# Brief description of code
This script facilitates an interactive augmented reality (AR) experience, toggling between two sets of text information upon user interaction with a Vuforia Virtual Button. Key functionalities include:

1. Text Toggling: Utilizes an array to store two text elements - bibliographic details and a personal review of the book "Who Loves You?". A virtual button press toggles the display between these texts on an AR overlay.

2. Arrow Visibility: Manages two arrow indicators (right and left) to signal the current text context and possible actions. The right arrow appears with bibliographic details, and the left arrow shows with the personal review, guiding the user interaction flow.

3. Cooldown Mechanism: Implements a cooldown period post-button press to prevent spamming, ensuring a stable user experience. This mechanism restricts text toggling until a defined time interval has elapsed since the last button interaction.

You can interact with the code by pressing play on the screen. 


# Limitations
A primary limitation of this script is the sensitivity and accuracy of the virtual button detection in Vuforia. The detection can be inconsistent, particularly with the positioning of the user's hand relative to the virtual button. Users might find that the button does not always recognize a press, especially if the hand is beneath the button or not aligned precisely. This issue stems from the way Vuforia's image recognition and virtual button functionality work, which can be influenced by lighting conditions, the quality of the AR marker, and the camera's capability to discern the interaction.

## Getting the Code Running
To download and run the AR application, follow these steps:

### Clone the GitHub Repository:
- **Find the GitHub repository** containing the AR project.
- **Clone the repository** to your local machine using Git with the command `git clone git@github.com:ShoggyR79/ar-book-cover.git`. Ensure you have Git installed on your computer to execute this step.

### Open the Project in Unity:
- **Open Unity Hub** and click on the 'Add' button to add an existing project.
- **Navigate to the cloned repository folder** and select it. Unity will then import the project into your Unity Hub project list.
- **Click on the project** in Unity Hub to open it in the Unity Editor.

### Navigate to the Scene:
- In the Unity Editor, go to the **"Assets/Scenes"** directory in the Project window.
- **Double-click on the main scene file** to open it. This scene should contain the pre-setup AR camera and virtual button objects.

### Ensure Vuforia Configuration:
- **Verify that Vuforia is enabled** in the project settings. Go to "Edit > Project Settings > XR Plugin Management" and ensure Vuforia AR is checked.
- **Check the Vuforia configuration** in the AR camera settings to ensure it's correctly set up with your Vuforia license key and database.

### Running the Application:
- With the scene open, **click on the "Play" button** in the Unity Editor to start the application in Play Mode.
- **Position a printed version of the AR marker** in front of your computer's webcam to test the virtual button functionality. The AR content should appear overlayed on the marker, and pressing the virtual button should toggle between the information displays as programmed.

By following these steps, you can download, set up, and run the AR application on your development machine using Unity and Vuforia.
