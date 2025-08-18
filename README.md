Folder Structure Conventions
============================

> Folder structure options and naming conventions for Back-End

### A typical API directory layout
    .
    ├── ...
    ├── App_Code                            # Any General Code related with Business Layer
    │   ├── Business Core.cs
    ├── Controllers                         
    │   ├── Folder App X                    # Create a new folder for each system
    │   │   ├── First Controller.cs
    │   │   └── Second Controller.cs
    │   └── Folder App Y
    ├── Models                         
    │   ├── Folder App X                    # Create a new folder for each system
    │   │   └── ...
    │   └── Folder App Y
    ├── Repository
    │   ├── Folder App X                    # Create a new folder for each system
    │   │   ├── First_Interface.cs          # Each table contains two files (Interface, Repository)
    │   │   └── First_Repository.cs         
    │   └── Folder App Y
    ├── ViewModel
    │   ├── Folder App X                    # Create a new folder for each system
    │   │   ├── VM_****.cs                  # Each ViewModel file is prefixed with 'VM_'
    │   │   └── VM_****.cs
    │   └── Folder App Y
    └── ...
