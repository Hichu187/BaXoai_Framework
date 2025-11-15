# 🎋 BaXoai Framework
*A lightweight and scalable framework for Unity development.*

---

## 🚀 Overview
**BaXoai Framework** is a clean, modular, and developer-friendly Unity toolkit designed to speed up production and simplify your project structure.  
It provides essential architecture patterns, UI utilities, data helpers, extension methods, and optional integrations for popular Unity tools.

This is the initial version — more features and modules will be added in future updates.

---

## ✨ Core Features

### 🧩 Architecture Patterns
- Singleton  
- State Machine  
- Object Pooling  
- Event System  
- (More patterns incoming…)

### 🎨 UI Utilities
- Button animations (scale, fade, pulse)  
- Image effects  
- Scroll helpers  
- UI extensions  

### 📦 Data & Helpers
- Scriptable data structure  
- Save/Load utilities  
- Runtime configuration helpers  
- Common extension methods  

---

## 📥 Installation

### 1️⃣ Install via Git URL  
Unity → *Package Manager* → *Add package from git URL*:

```
https://github.com/Hichu187/BaXoai_Framework.git
```

### 2️⃣ Install a specific version  
```
https://github.com/Hichu187/BaXoai_Framework.git#1.0.0
```

---

# 🔌 Integrations

BaXoai Framework supports optional integrations with popular Unity tools.  
These packages are **not included** inside the framework and must be installed separately.

---

## 📦 Dependencies

### 🔒 Required
BaXoai Framework does **not** require any third‑party assets to function.

### 🔓 Optional (Recommended)

| Package | Description | Required? |
|--------|-------------|-----------|
| **Odin Inspector** | Advanced inspectors and editor tooling | ❌ Optional |
| **DOTween** | Tweening library for UI and gameplay | ❌ Optional |

If installed, BaXoai will automatically enable additional helper utilities.

---

# ⚙️ Enabling Integrations

BaXoai Framework uses **Scripting Define Symbols** to toggle integration code.  
This prevents compilation errors if the user does not have the optional plugins installed.

---

## 🧩 Odin Integration

### 1️⃣ Install Odin Inspector  
(From Asset Store or local package)

### 2️⃣ Add scripting define symbol:
```
ODIN_INSPECTOR
```

Unity → *Project Settings* → *Player* → *Scripting Define Symbols*

### 3️⃣ Odin-based features unlocked:
- Serialized ScriptableObjects  
- Enhanced inspectors  
- Editor helpers  
- Additional utilities under `Integrations/Odin/`

---

## 🎮 DOTween Integration

### 1️⃣ Install DOTween  
From Asset Store or Git:

```
https://github.com/Demigiant/dotween
```

### 2️⃣ Add scripting define symbol:
```
DOTWEEN
```

### 3️⃣ DOTween features unlocked:
- UI animation helpers  
- Tween extensions  
- Animation presets  
- Utilities under `Integrations/DOTween/`

---

## 📁 Recommended Folder Structure

```
BaXoai_Framework/
│
├── Runtime/
│   ├── Core/
│   ├── UI/
│   ├── Data/
│   └── Extensions/
│
├── Editor/
│
└── Integrations/
    ├── Odin/
    └── DOTween/
```

---

## 📄 License
BaXoai Framework is released under the **MIT License**.

---

## 📌 Notes
This is the early version of the framework.  
More modules, documentation, and samples will be added in future updates.
