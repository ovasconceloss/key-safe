# 🔐 KeySafe – Secure Password Vault System

**KeySafe** is a secure, modern and free (open-source) system for storing and managing passwords, inspired by solutions like Bitwarden. All data is encrypted at rest with a focus on full privacy and security.

---

## 📌 Features

* User registration and login with JWT authentication
* Creation and management of personal vaults
* Storage of encrypted entries (passwords, notes, etc.)
* Sharing vaults with other users
* Secure master password rotation
* Access logs and change history

---

## 🚀 Technologies

* [.NET 8](https://dotnet.microsoft.com)
* ASP.NET Core Web API (MVC)
* Entity Framework Core
* ASP.NET Identity + JWT
* SQLite / PostgreSQL
* `System.Security.Cryptography`
* xUnit + Moq (tests)

---

## 🔐 Security

* AES symmetric encryption with PBKDF2-derived keys
* Password hashing with ASP.NET Identity (PBKDF2 with unique salt)
* "Zero Knowledge" storage: the server has no access to password contents
* Protection against brute-force and timing attacks

---

## 🧪 Tests

```bash
dotnet test
```

---

## 📄 License

This project is licensed under the MIT License. See the `LICENSE` file for more details.

---

## ✨ Credits

Developed by **Victor Vasconcelos** as a portfolio project focused on secure backend development using C# and .NET with MVC architecture.