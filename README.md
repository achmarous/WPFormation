# WPF Basics Learning Repository

Welcome to the **WPF Basics Learning Repository**! This project is designed to help beginners and intermediates get a solid foundation in **Windows Presentation Foundation (WPF)**. It covers essential concepts and practical examples to understand the key components of WPF development.

## Table of Contents
- [About](#about)
- [Getting Started](#getting-started)
- [Features Covered](#features-covered)
- [Key Concepts](#key-concepts)
- [Project Structure](#project-structure)
- [How to Use](#how-to-use)
- [Contributing](#contributing)
- [License](#license)

---

## About
WPF (Windows Presentation Foundation) is a powerful UI framework for building desktop client applications. This repository is focused on learning and exploring the most important parts of WPF to enable you to create modern, feature-rich applications.

Through practical examples and step-by-step tutorials, you will learn about:
- Basic WPF controls and their usage
- Data binding concepts
- MVVM (Model-View-ViewModel) pattern
- Layout management
- Styles, templates, and themes
- Event handling

This repository aims to give you hands-on experience with WPF development, laying a foundation for building more advanced desktop applications in the future.

---

## Getting Started

### Prerequisites
To run the examples in this repository, you will need:
- **Visual Studio** (2019 or later) with the **.NET desktop development** workload installed.
- **.NET Core SDK** (version 3.1 or higher) or **.NET Framework** (version 4.7.2 or higher).

### Setup Instructions
1. Clone this repository to your local machine:
    ```bash
    git clone https://github.com/yourusername/WPF-Basics-Learning.git
    ```
2. Open the solution file (`.sln`) in **Visual Studio**.
3. Restore NuGet packages if prompted.
4. Select a project and click **Start** to run and explore the example.

---

## Features Covered

### 1. **XAML Basics**
   - Understanding XAML (Extensible Application Markup Language)
   - Building a simple UI with XAML

### 2. **WPF Controls**
   - Common controls: `Button`, `TextBox`, `Label`, `ComboBox`, `ListView`
   - Advanced controls: `DataGrid`, `TreeView`, `TabControl`

### 3. **Layouts**
   - Using layout panels: `Grid`, `StackPanel`, `DockPanel`, `WrapPanel`
   - Positioning and aligning elements

### 4. **Data Binding**
   - One-way and two-way data binding
   - Binding to collections and `ObservableCollection`
   - Data templates

### 5. **MVVM Pattern**
   - Introduction to MVVM architecture
   - Creating ViewModels and binding to the View
   - Commands and handling events in MVVM

### 6. **Styles and Themes**
   - Creating reusable styles and resources
   - Applying control templates
   - Using themes for UI consistency

### 7. **Events and Routed Events**
   - Handling standard and custom events
   - Using routed events in WPF

### 8. **Resources and Resource Dictionaries**
   - Creating and referencing resources
   - Using resource dictionaries for clean code

### 9. **Animations and Visual States**
   - Simple animations with Storyboards
   - Visual state management

---

## Key Concepts

### **XAML**:
WPF uses XAML to define the UI. It separates the UI from business logic, making code more readable and maintainable.

### **MVVM (Model-View-ViewModel)**:
The MVVM pattern is a core architectural pattern in WPF. It separates the logic (ViewModel) from the UI (View) and models data in a clean and testable way.

### **Data Binding**:
Data binding is the cornerstone of WPF, enabling a seamless connection between UI elements and data sources, such as objects, properties, or collections.

### **Commands**:
Commands are used to handle input (e.g., button clicks) and actions in the MVVM pattern, promoting separation of concerns and making the code more maintainable.

---

## Project Structure

The repository is divided into different subfolders, each focusing on a specific topic within WPF:

```bash
WPF-Basics-Learning/
│
├── 01-XAML-Basics/        # Intro to XAML, simple UIs
├── 02-Controls/           # Common WPF controls examples
├── 03-Layouts/            # Layout management with panels
├── 04-DataBinding/        # Data binding concepts and examples
├── 05-MVVM/               # MVVM pattern introduction and examples
├── 06-Styles-Themes/      # Using styles and themes
├── 07-Events/             # Events and routed events
├── 08-Resources/          # Resource management
└── README.md              # You're here!
