# Project 2: AR Book Cover
Aadarsh Jha

### Introduction

In this project, a review of the book, "Diary Of A Wimpy Kid", is given through the use of AR. In particular, the front of the book is scanned and the user is able to see a virtual scene created, inspired by the general theme of the book. The back of the book can be scanned and will the user can see some salient information about the book. The user can then press a virtual button to then toggle the text, displaying a review of the book.

### How To Reproduce Project

First, please make sure that Unity and Unity Hub are installed. I am on Version 3.0.1 of Unity Hub, and I am using Unity Version 2020.3.26f1.

Execute the following steps to reproduce the project:

**Before cloning this repository**, please make sure you have installed Git LFS (Large File Storage) on your computer. This project was too big to be stored on GitHub, so I used Git LFS to store the project on my computer and on GitHub. Installation instructions may be found here: https://git-lfs.github.com/, note specifically the installation link and the `git lfs install` command.

1. First, clone the repository via `git clone https://github.com/aadarshjha/arbookproject`, in any directory you would like.
2. Then, open Unity Hub (I am using Version 3.0.1), and press the "Open" button under Projects.
3. Locate the directory you have cloned, and press the "Open" button.
4. Unity will open the project. It may take a bit of time to open the project initially.
5. Unity will open the project, but you may first encounter an "Untitled Scene". In the left lower pane, under the Assets folder, click on the "Scenes" folder.
6. You should see a scene called "BookCover". Click on this scene.
7. The scene will then open up and you can interact with the project.
8. Make sure to modify the Build Settings to point to an Android device, or generally any Mobile Device.
9. There is no need to download Vuforia, Assets, or any additional packages since Git LFS (large file storage) is used, so everything is already in the repo for you.

### Images
First a table of views for the Front Cover may be seen:

<table>
<tr>
<td>
<img src="./readme/1.jpg" alt="Front Cover" width="210" height="400">
</td>
<td>

<img src="./readme/2.jpg" alt="Front Cover" width="210" height="400">

</td>

<td>

<img src="./readme/3.jpg" alt="Front Cover" width="210" height="400">

</td>

</tr>

</table>

Then, a table of views for the Back Cover may be seen:

<table>

<tr>

<td>

<img src="./readme/4.jpg" alt="Front Cover" width="210" height="400">

</td>

<td>

<img src="./readme/5.jpg" alt="Front Cover" width="210" height="400">

</td>

</tr>

</table>

### Video

The following link displays a video of the project: https://www.youtube.com/watch?v=cb1DnJJp730

### Limitations

The limitations in this project are primarily the fidelity of the images used. In Vuforia, a score is given to the images, and the higher the score, the higher the fidelity of the image for AR purposes. In particular, the front cover is given a 5 star rating (highest score), but the back cover is given only a 4 star score (out of 5 stars). This is because I was not able to find the best quality, high-resolution image of the back cover (or, at least as good as the front-cover). This is because it is generally difficult to find back cover images.

Because of this, the tracking and AR representation of the back cover is not as good as the front cover, though the performance is still competitive.

Another limitation of the code / Vuforia is that the virtual button does not always register user input appropriately. Sometimes, the button will execute without input, and other times, it will not execute when touched. I attempted to solve this issue by turning down the sensitivity of the virtual button, and this seemed to work quite well, though more progress is needed.

Finally, a small issue is that, when switching book covers (i.e. the back cover to the front cover, and vice versa), it seems as though the virtual AR artifacts will sometimes stay on the screen for a bit, occluding the new view. However, I was largely able to solve this issue by removing extended tracking.
