# 🌯 Shawarma Management System

## ✨ **Overview**

Welcome to the **Shawarma Management System**! This desktop application simplifies the management of shawarma items, orders, and payment flows. Whether you're an admin managing shawarma inventory or processing orders and payments, this system offers a sleek and intuitive experience.

### **Key Features:**
- 🥙 **Shawarma Management**: Add, update, or delete various shawarma items (Chicken, Beef, Veg).
- 📦 **Order Tracking**: Track orders from **Processing** to **Delivered** and **Completed**.
- 💳 **Payment Handling**: Supports **Card**, **Cash**, and **Split Payments**.
- 🗃️ **Database Integration**: Seamlessly interacts with an **SQL Server** database to store and manage data.

---

## 🧑‍💻 **Architecture & Design Patterns**

The application is built using **well-known design patterns** to ensure maintainability and flexibility:

### ⚒️ **Creational Patterns**

#### 1. **Factory Method Pattern** 🌱
Used to create different types of shawarma (Chicken, Beef, Veg) based on the selected type. Each type has its own dedicated factory class (`ChickenShawarmaFactory`, `BeefShawarmaFactory`, `VegShawarmaFactory`), ensuring modularity and easy extensibility.

#### 2. **Singleton Pattern** 🛠️
Guarantees only one instance of `ShawarmaManager` exists, providing centralized control over the shawarma inventory. Ensures that inventory data remains consistent across the application.

---

### 🏗️ **Structural Patterns**

#### 3. **Adapter Pattern** 🔌
Used for seamless communication between the system and the `SqlServer` database. The `DatabaseAdapter` class allows the Shawarma Management System to work with various database implementations without tight coupling.

#### 4. **Proxy Pattern** 🎭
The `LoginProxy` class controls access to the `LoginService`. It provides additional functionalities, such as caching, logging, or access control, without modifying the core service.

---

### 💡 **Behavioral Patterns**

#### 5. **Strategy Pattern** 🔄
This pattern allows dynamic switching between different payment methods (e.g., **Card** or **Cash**) and supports **Split Payments**. Depending on user selection, the appropriate payment strategy is chosen at runtime, providing flexibility in handling payments.

#### 6. **State Pattern** 🔄
Manages the order state lifecycle. Orders can transition between the following states:
- **Processing**
- **Delivered**
- **Cancelled**
- **Completed**

This pattern decouples the order states and makes the system easier to extend and maintain.

---

## 📥 **Getting Started**

### 🔧 **Prerequisites**

To get started, ensure you have the following tools installed:

- **Visual Studio** (for Windows Forms development)
- **SQL Server** (for database management)

### 🚀 **Installation**

1. **Clone the repository** to your local machine:
   ```bash
   git clone https://github.com/irtezaofficial/shawarma-management-system.git
