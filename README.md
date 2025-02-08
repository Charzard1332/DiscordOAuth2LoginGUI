# 🎮 Discord OAuth2 Login - WinForms App

🚀 A **Windows Forms Application** that allows users to **log in via Discord OAuth2** and **fetch their profile data, Nitro status, and more**.

## ✅ Features
- 🔐 **Login via Discord OAuth2**
- 🎭 **Fetch & Display Discord Username & Nitro Status**
- 🎖 **Retrieve User's Badges**
- 🔗 **Get Connected Accounts (Steam, Xbox, etc.)**
- 🚀 **Display Boosted Servers**
- 🔄 **Automatic Token Refreshing**
- 🖼 **Show User's Avatar**
- 🔥 **User-Friendly Windows UI**

---

## ⚙️ Setup & Installation

### 🔹 **1️⃣ Clone the Repository**
```sh
git clone https://github.com/YOUR_GITHUB_USERNAME/DiscordOAuth2WinForms.git
cd DiscordOAuth2WinForms
```

### 🔹 **2️⃣ Change Client ID And Secret**
OAuthHelper.cs
```cs
private static readonly string clientId = "YOUR_CLIENT_ID_HERE";
private static readonly string clientSecret = "YOUR_CLIENT_SECRET_HERE";
private static readonly string redirectUri = "http://localhost:5000/callback";
```

### **3️⃣ Build Application**
```
Ctrl + Shift + b
```

## 🛠 Usage
- Open the provided **OAuth2 login URL** in your browser.
- Authorize the application using your Discord account.
- The app will fetch and display your **Discord username and Nitro status**.

---

## 📝 License
This project is open-source and available under the **MIT License**.

---

## 🌟 Contributing
Feel free to submit **issues** or **pull requests** to improve the project!
