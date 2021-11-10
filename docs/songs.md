# **Endpoint: Songs**

## **Get Requests**
---
<br>

**URL** : `/Songs`

**Auth required** : No

**Permissions required** : None

**Content Example:**
```json
{
    "id": 1,
    "title": "Stratego",
    "artistID": 1,
    "spotify": "https://open.spotify.com/track/6zctLQjQkNI0agikPLbO9N?si=ee91aa82eeb948a6",
    "youtube": "https://www.youtube.com/watch?v=mpuwr9fF7kw"
  },
  {
    "id": 2,
    "title": "Vampire",
    "artistID": 2,
    "spotify": "https://open.spotify.com/track/1fwbJjRup8QgLuf6D1BWcE?si=37d984c185154bd8",
    "youtube": "https://www.youtube.com/watch?v=sOyDORoMfwk"
  }
```
---
<br>

**URL** : `/Songs/{id}`

**Auth required** : No

**Permissions required** : None

<br>

## **Success Response**

**Code**: `200 Success`

**Content Example:**
```json
{
    "id": 1,
    "title": "Stratego",
    "artistID": 1,
    "spotify": "https://open.spotify.com/track/6zctLQjQkNI0agikPLbO9N?si=ee91aa82eeb948a6",
    "youtube": "https://www.youtube.com/watch?v=mpuwr9fF7kw"
}
```

## **Error Response**

**Code**: `404 Not Found`

```json
Song not found! Try another ID!
```
---

<br>

**URL** : `/Songs/{id}/votes`

**Auth required** : No

**Permissions required** : None

<br>

## **Success Response**

**Code**: `200 Success`

**Content Example:**
```json
{
    "id": 1,
    "ip": "81.83.102.133",
    "songID": 3,
    "points": 12
},
{
    "id": 2,
    "ip": "81.83.102.120",
    "songID": 3,
    "points": 3
}
```

## **Error Response**

**Code**: `404 Not Found`

```json
No votes found for the song with ID '{id}'! Try another ID!
```
---

<br>

**URL** : `/Songs/{id}/points`

**Auth required** : No

**Permissions required** : None

<br>

## **Success Response**

**Code**: `200 Success`

**Content Example:**
```json
15
```

## **Error Response**

**Code**: `404 Not Found`

```json
No points found for the song with ID '{id}'! Try another ID!
```
---

<br>

## **Post Requests**
---
<br>

**URL** : `/Songs`

**Auth required** : Yes

**Permissions required** : None

**Request Body Example:**
```json
{
  "title": "string",
  "artistID": 0,
  "spotify": "string",
  "youtube": "string"
}
```

## **Success Response**

**Code** : `200 Success`

```json
The song has been succesfully added!
```
---

<br>

## **Put Requests**
---
<br>

**URL** : `/Songs/{id}`

**Auth required** : Yes

**Permissions required** : Admin

**Request Body Example:**
```json
{
  "title": "string",
  "artistID": 0,
  "spotify": "string",
  "youtube": "string"
}
```

## **Success Response**

**Code** : `200 Success`

```json
The song with id '{id}' has been updated succesfully!
```

## **Error Response**

**Code** : `404 Not Found`

```json
Song not found! Try another ID!
```
---

<br>

## **Delete Requests**
---
<br>

**URL** : `/Songs/{id}`

**Auth required** : Yes

**Permissions required** : Admin


## **Success Response**

**Code** : `200 Success`

```json
The song with id '{id}' has been deleted succesfully!
```

## **Error Response**

**Code** : `404 Not Found`

```json
Song not found! Try another ID!
```
---