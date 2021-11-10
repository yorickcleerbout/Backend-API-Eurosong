![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)![JWT](https://img.shields.io/badge/JWT-black?style=for-the-badge&logo=JSON%20web%20tokens)![SQLite](https://img.shields.io/badge/sqlite-%2307405e.svg?style=for-the-badge&logo=sqlite&logoColor=white)![Swagger](https://img.shields.io/badge/-Swagger-%23Clojure?style=for-the-badge&logo=swagger&logoColor=white)

# **Programming Web**

This repository is made as part of a assignment of the course 'Programming Web'. The main goal of this course is to create some sort of "Eurosong" type API with front-end created with Vue.js attached to it. The backend API you can find in this repository but for the front-end there will be an other repository to keep things seperate.

[**Link to Front-End Repo: Coming soon**]()

# **Endpoints**

## **Open Endpoints:**
*Open endpoints require no Authentication.*

- [**Get all Songs**](docs/songs.md) : `GET /Songs`
- [**Get Songs by id**](docs/songs.md) : `GET /Songs/{id}`
- [**Get Votes by song id**](docs/songs.md) : `GET /Songs/{id}/votes`
- [**Get Points by song id**](docs/songs.md) : `GET /Songs/{id}/points`

<br>

- [**Get all Artists**](docs/artists.md) : `GET /Artists`
- [**Get Artists by id**](docs/artists.md) : `GET /Artists/{id}`
- [**Get Songs by Artist id**](docs/artists.md) : `GET /Artists/{id}/songs`
- [**Get Picture of Artist id**](docs/artists.md) : `GET /Artists/{id}/picture`

<br>

- [**Get all Votes**](docs/votes.md) : `GET /Votes`
- [**Get Votes by id**](docs/votes.md) : `GET /Artists/{id}`

<br>

## **Endpoints that require Authentication:**

*Closed endpoints require Basic Authentication credentials to be included in the header of the request as a **Base64Encoded** string.*

- [**Add new Song to Database**](docs/songs.md) : `POST /Songs`
- [**Update a Song in the Database**](docs/songs.md) : `PUT /Songs/{id}`
- [**Remove a Song from the Database**](docs/songs.md) : `DELETE /Songs/{id}`

<br>

- [**Add new Artist to Database**](docs/artists.md) : `POST /Artists`
- [**Update an Artist in the Database**](docs/artists.md) : `PUT /Artists/{id}`
- [**Remove an Artist from the Database**](docs/artists.md) : `DELETE /Artists/{id}`

<br>

- [**Add new Vote to Database**](docs/votes.md) : `POST /Votes`
- [**Update a Vote in the Database**](docs/votes.md) : `PUT /Votes/{id}`
- [**Remove a Vote from the Database**](docs/votes.md) : `DELETE /Votes/{id}`




