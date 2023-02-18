# Rent-a-Car-DDD

## ER diagram

![image_2023-02-03_102415651](https://user-images.githubusercontent.com/58531861/216562377-af920614-6971-4fc2-a04f-3a799112a48b.png)

## Bilješke

#### Kreiranje migracije i baze podataka:

- Otvoriti Package Manager Console
- Default project treba biti projekt u kojem se nalazi dbContext (Persistence projekt)
- Pokreniti prvo naredbu:

  ```powershell
  Add-Migration "NazivMigracije"
  ```

- Pokreniti naredbu
  ```powershell
  update-database
  ```
