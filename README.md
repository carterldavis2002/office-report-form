# WinForms Office Contact Reporter
A simple Windows application designed to help keep track of contact information. The program manages input text data files with or without pre-existing contact
information and allows you to add entries, search for an entry based on a filter, change entry information, and more. Any changes made with the program are reflected in
the modified data file so it can be opened again at a later point to perform operations on the new data.

## Download & Usage
To run the application, the [.NET 6.0 Desktop Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0/runtime) must be installed on the system you wish to run the program on. 
Once you have confirmed the runtime is installed, download one of the [release EXEs](https://github.com/carterldavis2002/office-report-form/releases) to the system. 
Opening this downloaded file will run the application.

**NOTE:** Windows is the only operating system officially supported by this application. The program may not work correctly on others such as macOS and Linux.

Upon starting the program, you will be asked to select a file on your system ending in .txt. The selected file will be the one that is written to when operations are
performed in the application. It may contain pre-existing contact information or none. **WARNING:** The contents of the selected .txt file, whatever they may be, will all be
overwritten by the program once chosen, so be careful!

The format of the contact information in the file that the application reads/writes out to is as follows:
```
NameOne Office-# Telephone-#-in-format(000-000-0000)
NameTwo Office-# Telephone-#-in-format(000-000-0000)
NameThree Office-# Telephone-#-in-format(000-000-0000)
```
The program will only consider entries in this format to be valid and acceptable to perform operations on.

Upon selecting a data file, you will be able to press buttons to perform the labeled operations on the read data, using entered textbox values as input. For example,
to add a contact, enter a name, office #, and telephone # and press the button labeled ``Add an entry``. If the information entered was valid, you will see in the
output box that the entry was successfully added. Otherwise the output box will display any errors with the given input and/or how to fix them.

## Development Setup
### Requirements
- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download)
- Git

Clone the repo
```
git clone https://github.com/carterldavis2002/office-report-form.git
```
In the project directory, run ``dotnet build`` to build the project and ``dotnet run`` to run the application. The distributable executable is located in 
``bin\Debug\net6.0-windows`` upon building.
