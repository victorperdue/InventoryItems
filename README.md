# InventoryItems
Overview
The Inventory Application is a simple Windows Forms application built in C# using Visual Studio. It simulates an inventory system for storing and displaying a list of items (e.g., Pokémon). The application provides a graphical user interface (GUI) with a ListBox to display inventory items and a Button to trigger inventory display.

Features
Item Management:
Each item includes attributes such as name, type, height, weight, and evolution form.
Graphical User Interface:
A ListBox displays the inventory items.
A Button allows the user to populate and display the inventory.
Predefined Items:
The inventory includes predefined Pokémon for demonstration purposes.
Dynamic Updates:
The application dynamically adds and displays inventory items when the button is clicked.
Classes and Functionality
1. Form1 (Main Form)
Purpose: The primary user interface for the application.
Key Elements:
ListBox: Displays the inventory items in a list format.
Button: Triggers the display of inventory items in the ListBox.
Key Methods:
Form1_Load: Populates the inventory with predefined items when the form loads.
btnShowInventory_Click: Handles the button click event to display inventory items in the ListBox.
2. Item (Model Class)
Purpose: Represents an individual item in the inventory.
Properties:
Name: Name of the item.
Type: Type or category of the item.
Height: Height of the item (in meters).
Weight: Weight of the item (in kilograms).
EvolutionForm: Next evolution of the item (if any).
Methods:
ToString: Overrides the ToString method to format the item's details for display.
3. Inventory (Model Class)
Purpose: Manages a collection of items.
Properties:
Items: A list to store inventory items.
Methods:
AddItem: Adds an Item to the inventory list.
How to Use
Open the project in Visual Studio.
Build and run the application.
The form will load with the inventory prepared in the Form1_Load method.
Click the "Show Inventory" button to display the list of items in the inventory.
Predefined Inventory
The application comes with the following predefined Pokémon:

Pikachu: Electric type, evolves into Raichu.
Bulbasaur: Grass/Poison type, evolves into Ivysaur.
Charmander: Fire type, evolves into Charmeleon.
Squirtle: Water type, evolves into Wartortle.
Eevee: Normal type, evolves into Vaporeon, Jolteon, or Flareon.
Requirements
Development Environment: Visual Studio
Target Framework: .NET Framework
Languages Used: C#
Future Enhancements
Dynamic Item Input:
Allow users to add new items through the GUI.
Search and Filter:
Add functionality to search or filter items based on specific attributes.
Persistent Storage:
Save the inventory to a file or database for persistent storage.
Enhanced GUI:
Add images or icons for items to improve the visual experience.
License
This project is open-source and can be used or modified freely for educational purposes.
