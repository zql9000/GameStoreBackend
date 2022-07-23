# GameStoreBackend

´´´
erDiagram
Genre ||--|{ Game : has
Game ||--|{ Purchase : sold
Customer ||--|{ Purchase : make
Country ||--|{ Customer : has
Developer ||--|{ Game : create

    Genre {
        int Id PK
        string Description
    }

    Developer {
        int Id PK
        string Name
    }

    Country {
        int Id PK
        string Name
    }

    Customer {
        int Id PK
        int CountryId FK
        string Username
        string Password
        string Name
        string Lastname
    }

    Game {
        int Id PK
        int GenreId FK
        int DeveloperId FK
        string Title
        string Synopsis
        decimal Price
    }

    Purchase {
        int Id PK
        int GameId FK
        int CustomerId FK
        DateTime Date
        decimal Price
    }

´´´
