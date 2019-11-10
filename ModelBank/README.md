# ModelBank
v. 1.0.4

## Caveats
Hi, this code is almost completely undocumented outside of this README. Sorry! Please follow these instructions to the letter.

This code has almost no protection against edge cases as of v. 1.0.4, so please be very careful how you implement this. Remember to catch FileNotFoundExceptions!

## Exceptions to catch
* If your model manifest is formatted incorrectly, you MIGHT get a FileLoadException. Don't count on it, but catch it regardless.
* If your page manifest contains model names that don't exist in your book, you'll get a ModelDoesNotExistException. Catch this. 
* Obviously, if you're pointing to files that don't exist, you'll get a FileNotFoundException. Catch!!

## Executable Instructions
To run the executable, pass four arguments: absolute path to the model manifest, absolute path to the page manifest, page number, and model number (indexed at zero).

*WARNING*: not advised unless you can handle exceptions or you **know** your input is correct

## Object Usage Instructions
1. You'll want two manifest files: a file with model names and directories, and a file with pages and model names. Create these in the following formats:
    * Model Manifest: on each line, a model name, followed by a pipe, followed by a file path, relative to your Unity Models directory. Use forward slashes or \\escaped backslashes.
        * Example: `Caffeine|caffeine.obj`
    * Page Manifest: on each line, a series of model names separated by commas.
        * Example: `Caffeine,Hydrochloric Acid,Buckminsterfullerene`
2. Either import the nuget package into your code...
    1. Add to your .csproj file in PropertyGroup:  
       ```xml
       <RestoreSources>$(RestoreSources);absolute/path/to/folder/containing/package;https://api.nuget.org/v3/index.json</RestoreSources>
       ```
    2. Call `dotnet add app package ModelBank` from the solution root
    3. Add a `using ModelBank;` statement to the top of your `.cs` file where you're using the package
3. ...or import [ModelBank.dll](obj/Debug/netcoreapp3.0/ModelBank.dll).
4. Create a new `ModelBank` object by constructing it with a name string for your book
5. Add models to your book by calling `<your ModelBank object>.MakeBook(pathToModelManifest)`
6. Add pages to your book by calling `<your ModelBank object>.MakePages(pathToPageManifest)`
7. To get the path to a model file for the `n`th model on the `m`th page, call `<your ModelBank object>.GetUnityPath(m, n)` (both indexed at zero).

## Credits
* Blessed be to Microsoft for their .NET documentation
* Thank you to Sam Stern, Anna Cowett (our rubber duck), and Viking Mayor for moral support
* Best of luck to you, Max.
