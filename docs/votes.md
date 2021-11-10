# **Endpoint: Votes**

## **Get Requests**
---
<br>

**URL** : `/Votes`

**Auth required** : No

**Permissions required** : None

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
},
{
    "id": 3,
    "ip": "81.83.112.80",
    "songID": 1,
    "points": 8
}
```
---
<br>

**URL** : `/Votes/{id}`

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
}
```

## **Error Response**

**Code**: `404 Not Found`

```json
Vote not found! Try another ID!
```
---

<br>

## **Post Requests**
---
<br>

**URL** : `/Votes`

**Auth required** : Yes

**Permissions required** : None

**Request Body Example:**
```json
{
  "ip": "string",
  "songID": 0,
  "points": 0
}
```

## **Success Response**

**Code** : `200 Success`

```json
The Vote has been succesfully added!
```
---

<br>

## **Put Requests**
---
<br>

**URL** : `/Votes/{id}`

**Auth required** : Yes

**Permissions required** : Admin

**Request Body Example:**
```json
{
  "ip": "string",
  "songID": 0,
  "points": 0
}
```

## **Success Response**

**Code** : `200 Success`

```json
The vote with id '{id}' has been updated succesfully!
```

## **Error Response**

**Code** : `404 Not Found`

```json
Vote not found! Try another ID!
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
The vote with id '{id}' has been deleted succesfully!
```

## **Error Response**

**Code** : `404 Not Found`

```json
Vote not found! Try another ID!
```
---