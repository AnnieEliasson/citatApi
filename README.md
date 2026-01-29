# QuoteAPI - Random Weather Quotes

### 🎲 Random quote

 - **GET** /api/quote

```json
{
  "id": 1,
  "text": "Efter regn kommer… mer regn. Men också erfarenhet."
}
```
---

### 📚 All quotes

 - **GET** /api/quote/all

```json
[
    {
        "id": 1,
        "text": "Efter regn kommer… mer regn. Men också erfarenhet."
    },
    ...
]
```
---
### 🔎 Quote by Id

- **GET** /api/quote/1

```json
{
  "id": 1,
  "text": "Efter regn kommer… mer regn. Men också erfarenhet."
}
```
---

### 🔍 Search quote

- **POST** /api/quote/search?s=regn

```json
[
  {
    "id": 1,
    "text": "Efter regn kommer… mer regn. Men också erfarenhet."
  },
  {
    "id": 7,
    "text": "Regn förstör inga planer – det avslöjar bara hur flexibla de var."
  }
]
```
---
