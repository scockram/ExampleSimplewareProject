# Example Simpleware Project

Steps to use the project

* Clone the repo
* Add the files `SimpleITKCSharpManaged.dll` and `SimpleITKCSharpNative.dll` to the `Resources/` directory. [Available from Sourceforge](http://sourceforge.net/projects/simpleitk/files/SimpleITK/)
* Add the file `ScanIP.dll` to `Resources/`. This can (normally) be found at `C:\Program Files\Simpleware\ScanIP`.
* Run `make` (may need to adjust exact path to compiler in the makefile)
* Copy files to ScanIP Plugins directory: `xcopy Build\* %HOMEPATH%\ScanIPPlugins`
