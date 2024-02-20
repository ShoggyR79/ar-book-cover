# ar-book-cover

# Link to demo
https://youtu.be/xIh7yyMQoNc

# Images
The images are created by first capturing the book on the phone and sending it to the computer in ```./cover_images.pdf``` and then using vuforia database import created as target and downloaded to the computer (that file is ```./phd.unitypackage```)

# Brief description of code
The only script created for this project is ```Assets/vb_anim.cs```. 
This script facilitates an interactive augmented reality (AR) experience, toggling between two sets of text information upon user interaction with a Vuforia Virtual Button. Key functionalities include:

1. Text Toggling: Utilizes an array to store two text elements - bibliographic details and a personal review of the book "Who Loves You?". A virtual button press toggles the display between these texts on an AR overlay.

2. Arrow Visibility: Manages two arrow indicators (right and left) to signal the current text context and possible actions. The right arrow appears with bibliographic details, and the left arrow shows with the personal review, guiding the user interaction flow.

3. Cooldown Mechanism: Implements a cooldown period post-button press to prevent spamming, ensuring a stable user experience. This mechanism restricts text toggling until a defined time interval has elapsed since the last button interaction.

You can interact with the code by pressing play on the screen. 


# Limitations
A primary limitation of this script is the sensitivity and accuracy of the virtual button detection in Vuforia. The detection can be inconsistent, particularly with the positioning of the user's hand relative to the virtual button. Users might find that the button does not always recognize a press, especially if the hand is beneath the button or not aligned precisely. This issue stems from the way Vuforia's image recognition and virtual button functionality work, which can be influenced by lighting conditions, the quality of the AR marker, and the camera's capability to discern the interaction.

## Setup Guide for AR Application

To set up and run the AR application, please follow these steps in the exact order provided:

### Step 1: Download the GitHub Repository

- Navigate to the GitHub repository containing the AR project.
- Download the entire repository to your local machine.

### Step 2: Download and Install Vuforia Package

- Follow the Vuforia Engine's documentation to download the `add-vuforia-package`.
- This step is crucial for adding Vuforia's AR capabilities to your Unity project.

### Step 3: Create a New Unity Project

- Open Unity Hub and create a new 3D project.
- Ensure you select the 3D template for the project to properly support the AR content.

### Step 4: Import Vuforia Engine to Your Project

- With your new project open in Unity, import the `add-vuforia-package` you downloaded from Vuforia.
- This will add the necessary Vuforia Engine AR capabilities to your Unity project.

### Step 5: Import `phd.unitypackage`

- Import the `phd.unitypackage` into your project.
- This package contains essential assets and configurations for the AR experience.

### Step 6: Replace the Assets Folder

- Replace everything in the Unity project's `Assets` folder with the contents of the `Assets` folder from the GitHub repository you downloaded.
- It's important to perform this step **after** importing the Vuforia package and `phd.unitypackage` to ensure all dependencies are correctly set up.

### Step 7: Open the Main Scene and Run

- Navigate to the `Scenes` folder within the `Assets` directory in Unity.
- Open the `SeussWhoLovesYou` scene.
- You can now run the project by clicking the `Play` button in Unity. This will launch the AR experience based on the scene you've just opened.

### Important Notes:

- **Follow the Steps in Order**: It's crucial to follow these steps in the specified order to ensure that all dependencies and assets are correctly integrated into your Unity project.
- **Vuforia Configuration**: Ensure that you have configured Vuforia within Unity according to Vuforia's documentation, including setting up a license key if required.
- **Testing the Application**: To test the AR functionality, you'll need a printed version of the AR marker that the application targets. Position this marker in front of your computer's webcam or your mobile device's camera while running the scene.

This setup guide is designed to help you correctly configure the AR application in Unity with Vuforia support, ensuring a smooth development and testing process.
these steps, you can download, set up, and run the AR application on your development machine using Unity and Vuforia.
