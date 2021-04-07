# Default User Avatar 
This is just a random piece of code I wrote for an application that needs to generate default user avatars based on their name. It will use the first character from the first argument and the first character from the second argument. It will return a base64 string which could be used to store in the database. You also have the option to save the file locally.

<br>
<br>

# Future
In the future I want to make changes to this code so you can easily change the size of the image that is generated without having to redefine where to text should be located manually

<br>
<br>

# Featured
This piece of code is used in the Tercera-GO Application by [Tercera](https://tercera.nl/) to generate default user avatars. 

<br>
<br>

# Contact
Please get in contact with me if something needs to be changed. You can contact me though the email which is shown on [my public GitHub profile](https://github.com/mutedev/) Please also let me know if you might use this. It always makes me happy to know and if you let me know I know that I could keep working on it! ❤

<br>
<br>

# Examples
Examples on how to use the code can be found in the Program.cs file located in this repository. Here's some examples out of context.

<br>

## Generate an image and save it to a base64 string
For this you will need to call the method, you only need to provide two arguments for this to start working (unless you want different colors which we will get to later) you can save the string that the method returns and save it elsewhere
```c#
String Base64ImageString = DefaultAvatar.GenerateAvatar("Myu", "Developer");
```

<br>

## Generate an image and save it locally (and save it as a base64 string)
For this you will call the same method. If you want to save the file you add the third argument which will be the file path which will indicate where the generated image has to be saved. Note that it will be formatted in the PNG format. Optionally you can also save the string that is returned. This string will always be generated when running the method.
```c#
String Base64ImageString = DefaultAvatar.GenerateAvatar("Myu", "Developer", "./myu1.png");
```
![Myu1](https://raw.githubusercontent.com/mutedev/DefaultUserAvatar/main/myu1.png)

<br>

## Generate an image with a custom background color
You can give the image a custom background color, the default is `rgb(6, 39, 70)`. You can override this using the System.Drawing.Common package.
```c#
DefaultAvatar.GenerateAvatar("Myu", "Developer", "./myu2.png", Color.FromArgb(200, 10, 100));
```
![Myu2](https://raw.githubusercontent.com/mutedev/DefaultUserAvatar/main/myu2.png)

<br>

## Generate an image with a custom background and text color
You can also customize the color of the text that is in the image by providing another argument
```c#
DefaultAvatar.GenerateAvatar("Myu", "Developer", "./myu3.png", Color.White, Brushes.HotPink);
```
![Myu3](https://raw.githubusercontent.com/mutedev/DefaultUserAvatar/main/myu3.png)

<br>

### The images that are generated can be found in the root folder of this repository
