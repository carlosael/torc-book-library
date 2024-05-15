# Royal Book Library

Royal Book Library is an application designed to consult a library's inventory of books, allowing users to search books by author or ISBN. This project aims to provide an easy-to-use interface for library administrators and patrons to efficiently access book resources.

## Features

- **Search and Filter**: Users can search for books by author or ISBN and filter results based on various criteria.

## Technologies Used

- **Backend**: .Net 8.0 with Entity Framework
- **Database**: MS SQL, Microsoft SQL Server Management Studio for schema-based modeling
- **Frontend**: React.js
- **Styling**: CSS

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

What things you need to install the software and how to install them:

- **MS SQL**
- **Git**
- **dotnet**
- Package manager **npm** or **yarn**

### Installing

A step-by-step series of examples that tell you how to get a development environment running:

## Start the database

Make sure MS SQL is running on your machine. If using a service like Microsoft SQL Server Management Studio for schema-based modeling, ensure your connection string is configured in your environment variables. Run the script on schema.sql file.

## Front-end

**Clone the repository**

```sh
 $ git clone https://github.com/carlosael/torc-book-library.git
```

**Install dependencies**

```sh
  $ cd royal-library-front
  $ yarn or npm install
  $ yarn start or npm run start
```

## Back-end

**Install dependencies**

```sh
    $ cd royal-library-api
    $ dotnet restore
```
