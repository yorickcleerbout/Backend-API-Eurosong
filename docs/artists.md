# **Endpoint: Artists**

## **Get Requests**
---
<br>

**URL** : `/Artists`

**Auth required** : No

**Permissions required** : None

**Content Example:**
```json
{
    "id": 1,
    "name": "Iron Maiden",
    "picture": "https://www.graspop.be/images/bands/detail/gmm-2020-iron-maiden-jm8RxPdzCjRywVY-1.jpg"
  },
  {
    "id": 2,
    "name": "Solence",
    "picture": "https://media.altpress.com/uploads/2020/08/SOLENCE.jpg"
  },
  {
    "id": 3,
    "name": "Smash Into Pieces",
    "picture": "https://dynamicmedia.livenationinternational.com/Media/y/c/b/ee4f36e8-8e60-4c1b-be1c-00cda5cf24af.jpg"
  }
```
---
<br>

**URL** : `/Artists/{id}`

**Auth required** : No

**Permissions required** : None

<br>

## **Success Response**

**Code**: `200 Success`

**Content Example:**
```json
{
  "id": 1,
  "name": "Iron Maiden",
  "picture": "https://www.graspop.be/images/bands/detail/gmm-2020-iron-maiden-jm8RxPdzCjRywVY-1.jpg"
}
```

## **Error Response**

**Code**: `404 Not Found`

```json
Artist not found! Try another ID!
```
---

<br>

**URL** : `/Artists/{id}/songs`

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
  },
  {
    "id": 4,
    "title": "Lost In A Lost World",
    "artistID": 1,
    "spotify": "https://open.spotify.com/track/0snEBWqLtpH1lONPTiNref?si=13150d27e7db4f8b",
    "youtube": "https://www.youtube.com/watch?v=ieSXL6ElP68"
  }
```

## **Error Response**

**Code**: `404 Not Found`

```json
No songs found for the artist with id '{id}'! Try another ID!
```
---

<br>

**URL** : `/Artists/{id}/picture`

**Auth required** : No

**Permissions required** : None

<br>

## **Success Response**

**Code**: `200 Success`

**Content Example:**
```json
https://www.graspop.be/images/bands/detail/gmm-2020-iron-maiden-jm8RxPdzCjRywVY-1.jpg
```

## **Error Response**

**Code**: `404 Not Found`

```json
Artist not found! Try another ID!
```
---

<br>

## **Post Requests**
---
<br>

**URL** : `/Artists`

**Auth required** : Yes

**Permissions required** : None

**Request Body Example:**
```json
{
  "name": "string",
  "picture": "string"
}
```

## **Success Response**

**Code** : `200 Success`

```json
The Artist has been succesfully added!
```
---

<br>

## **Put Requests**
---
<br>

**URL** : `/Artists/{id}`

**Auth required** : Yes

**Permissions required** : Admin

**Request Body Example:**
```json
{
  "name": "string",
  "picture": "string"
}
```

## **Success Response**

**Code** : `200 Success`

```json
The artist with id '{id}' has been updated succesfully!
```

## **Error Response**

**Code** : `404 Not Found`

```json
Artist not found! Try another ID!
```
---

<br>

## **Delete Requests**
---
<br>

**URL** : `/Artists/{id}`

**Auth required** : Yes

**Permissions required** : Admin


## **Success Response**

**Code** : `200 Success`

```json
The artist with id '{id}' has been deleted succesfully!
```

## **Error Response**

**Code** : `404 Not Found`

```json
Artist not found! Try another ID!
```
---